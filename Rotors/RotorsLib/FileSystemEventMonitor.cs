﻿using RotorsLib.Exceptions;
using RotorsWorkFlow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RotorsLib
{
    public class FileSystemEventMonitor
    {

        private string fileSystemPath;
        public event EventHandler Triggered;
        public FileSystemEventMonitor(string fileSystemPath)
        {
            this.fileSystemPath = fileSystemPath;
        }
        

        public void StartMonitoring()
        {
            if (string.IsNullOrEmpty(fileSystemPath))
            {
                throw new RotorsException("file system path is null or empty");
            }
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = fileSystemPath;
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            // watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private Timer timer = null;

        // Define the event handlers. 
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (timer == null)
            {
                timer = new Timer(new TimerCallback((o) =>
                {
                    if (Triggered != null)
                    {
                        Triggered(this, null);
                    }
                    
                }));
            }
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        
    }
}