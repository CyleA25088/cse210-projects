### **Product** (Program 2: Encapsulation with Online Ordering)

| **Product** |                                                                                         |
| ----------- | --------------------------------------------------------------------------------------- |
| **Fields**  | – `_name : string`  <br>– `_productId : string`  <br>– `_pricePerUnit : double`  <br>– `_quantity : int` |
| **Methods** | + `Product(name : string, productId : int, pricePerUnit : int, quantity : int)`  <br>+ `GetTotalCost() : double`  <br>+ `GetName() : string`  <br>+ `GetId() : string`  <br>+ `ToString() : string` |

**Description:**  
Encapsulates product details and computes its total cost.

---

### **Address**

| **Address** |                                                                                                 |
| ----------- | ----------------------------------------------------------------------------------------------- |
| **Fields**  | – `_street : string`  <br>– `_city : string`  <br>– `_stateOrProvince : string`  <br>– `_country : string` |
| **Methods** | + `Address(street, city, stateOrProvince, country)`  <br>+ `IsUS() : bool`  <br>+ `ToString() : string` |

**Description:**  
Holds address fields. Knows if it is in the USA. Returns a formatted address.

---

### **Customer**

| **Customer** |                                                                                   |
| ------------ | --------------------------------------------------------------------------------- |
| **Fields**   | – `_name : string`  <br>– `_address : Address`                                   |
| **Methods**  | + `Customer(name, address)`  <br>+ `GetName() : string`  <br>+ `GetAddress() : Address`  <br>+ `IsInUSA() : bool` |

**Description:**  
Holds customer name and address. Delegates country check to Address.

---

### **Order**

| **Order** |                                                                                                        |
| --------- | ------------------------------------------------------------------------------------------------------ |
| **Fields**  | – `_products : List<Product>`  <br>– `_customer : Customer`                                           |
| **Methods** | + `Order(customer : Customer)`  <br>+ `AddProduct(p : Product) : void`  <br>+ `CalculateTotal() : double`  <br>+ `GetPackingLabel() : string`  <br>+ `GetShippingLabel() : string` |

**Description:**  
Calculates order totals and returns packing and shipping labels. Applies $5 or $35 shipping depending on customer country.

---

### **Program**

| **Program** |                                                                                   |
| ---------------- | --------------------------------------------------------------------------------- |
| **Fields**       | – `_orders : List<Order>`                                                         |
| **Methods**      | + `Main(args : string[]) : void`  <br>+ `CreateSampleOrders() : void`  <br>+ `DisplayOrderSummaries() : void` |

**Description:**  
Creates at least two orders. Shows packing labels, shipping labels, and totals.


back to [main](../README.md)