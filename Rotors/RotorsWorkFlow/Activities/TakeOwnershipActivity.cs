﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;

namespace RotorsWorkFlow.Activities
{

    public sealed class TakeOwnershipActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            PropertyDescriptorCollection propertyDescriptorCol = context.DataContext.GetProperties();

            foreach (PropertyDescriptor pd in propertyDescriptorCol)
            {
                if (string.Equals(pd.Name, Constants.FileVariableName))
                {
                    FileItem[] files = (FileItem[])pd.GetValue(context.DataContext);
                    foreach (FileItem service in files)
                    {
                        ReplaceFileHelper.TakeOwnership(service);
                    }
                }
            }
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);
        }
    }
}
