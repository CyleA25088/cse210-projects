
### **Event** (Program 3: Inheritance with Event Planning)

| **Event** |                                                                                       |
| --------- | ------------------------------------------------------------------------------------- |
| **Fields**  | – `_title : string`  <br>– `_description : string`  <br>– `_date : DateTime`  <br>– `_time : TimeSpan`  <br>– `_address : Address` |
| **Methods** | + `Event(title, description, date, time, address)`  <br>+ `GetStandardDetails() : string`  <br>+ `GetFullDetails() : string`  <br>+ `GetShortDescription() : string` |

**Description:**  
Base class with shared fields and three message methods.

---

### **Lecture : Event**

| **Lecture : Event** |                                                                                   |
| ------------------- | --------------------------------------------------------------------------------- |
| **Fields**          | – `_speaker : string`  <br>– `_capacity : int`                                   |
| **Methods**         | + `Lecture(..., speaker, capacity)`  <br>+ `GetFullDetails() : string`            |

**Description:**  
Adds speaker and capacity. Full details include those.

---

### **Reception : Event**

| **Reception : Event** |                                                                                 |
| --------------------- | ------------------------------------------------------------------------------- |
| **Fields**            | – `_rsvpEmail : string`                                                         |
| **Methods**           | + `Reception(..., rsvpEmail)`  <br>+ `GetFullDetails() : string`                |

**Description:**  
Adds RSVP email. Full details include RSVP info.

---

### **OutdoorGathering : Event**

| **OutdoorGathering : Event** |                                                                         |
| ---------------------------- | ----------------------------------------------------------------------- |
| **Fields**                   | – `_weatherForecast : string`                                           |
| **Methods**                  | + `OutdoorGathering(..., weatherForecast)`  <br>+ `GetFullDetails() : string` |

**Description:**  
Tracks weather notes. Full details include weather statement.

---

### **Program**

| **Program** |                                                                 |
| ---------------- | --------------------------------------------------------------- |
| **Fields**       | – `_events : List<Event>`                                       |
| **Methods**      | + `Main(args : string[]) : void`  <br>+ `CreateSampleEvents() : void`  <br>+ `DisplayEventMessages() : void` |

**Description:**  
Creates one of each event type. Prints all three message forms per event.


back to [main](../README.md)