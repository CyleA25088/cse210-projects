### **Activity** (Program 4: Polymorphism with Exercise Tracking)

| **Activity** |                                                                 |
| ------------ | --------------------------------------------------------------- |
| **Fields**   | – `_date : DateTime`  <br>– `_minutes : int`                    |
| **Methods**  | + `Activity(date : DateTime, minutes : int)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double`  <br>+ `GetSummary() : string` |

**Description:**  
Base class. Defines virtual calculation methods used by derived types.

---

### **Running : Activity**

| **Running : Activity** |                                                                 |
| ---------------------- | --------------------------------------------------------------- |
| **Fields**             | – `_distanceMiles : double` (or store and compute)             |
| **Methods**            | + `Running(date, minutes, distanceMiles)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

**Description:**  
Calculates running distance, mph, and pace.

---

### **Cycling : Activity**

| **Cycling : Activity** |                                                           |
| ---------------------- | --------------------------------------------------------- |
| **Fields**             | – `_speedMph : double`  (or store distance)               |
| **Methods**            | + `Cycling(date, minutes, speedMph)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

**Description:**  
Calculates distance from speed and time. Provides mph and pace equivalents.

---

### **Swimming : Activity**

| **Swimming : Activity** |                                                                  |
| ----------------------- | ---------------------------------------------------------------- |
| **Fields**              | – `_laps : int`                                                   |
| **Methods**             | + `Swimming(date, minutes, laps)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

**Description:**  
Uses lap length (50 m) to compute distance. Converts to miles or km and then calc speed and pace.

---

### **ActivityProgram**

| **ActivityProgram** |                                                                         |
| ------------------- | ----------------------------------------------------------------------- |
| **Fields**          | – `_activities : List<Activity>`                                         |
| **Methods**         | + `Main(args : string[]) : void`  <br>+ `CreateSampleActivities() : void`  <br>+ `DisplaySummaries() : void` |

**Description:**  
Creates one activity of each type. Puts them in one list. Calls `GetSummary()` for each.

------------------------------------------------------------

### **Program** (Master controller - Diagram 5)

| **Program** |                                                                                      |
| ----------------------- | ------------------------------------------------------------------------------------ |
| **Fields**              | – `_videoProgram : VideoProgram`  <br>– `_orderProgram : OrderProgram`  <br>– `_eventProgram : EventProgram`  <br>– `_activityProgram : ActivityProgram` |
| **Methods**             | + `Main(args : string[]) : void`  <br>+ `DisplayMainMenu() : void`  <br>+ `RunModule(choice : int) : void`  <br>+ `SaveAll(path : string) : void`  <br>+ `LoadAll(path : string) : void` |

**Description:**  
Top-level driver. Lets user run each module. Coordinates persistence across modules.



back to [main](../README.md)