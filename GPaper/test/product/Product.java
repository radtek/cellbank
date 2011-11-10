/**
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership. The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
package product;

import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
@XmlType(name="Product", namespace="http://www.ist.sjtu.edu.cn")
@XmlRootElement(name = "Product",namespace="http://www.ist.sjtu.edu.cn")
public class Product {
    private long id;
    private String name;
    private long quantity;
    private double price;

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    public long getQuantity(){
    	return quantity;
    }
    public void setQuantity(long quantity){
    	this.quantity = quantity;
    }
    public double getPrice(){
    	return price;
    }
    public void setPrice(double price){
    	this.price = price;
    }
}
