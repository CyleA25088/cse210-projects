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
| **Methods**            | + `Running(date : DateTime, minutes : int, distanceMiles : double)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

**Description:**  
Calculates running distance, mph, and pace.

---

### **Cycling : Activity**

| **Cycling : Activity** |                                                           |
| ---------------------- | --------------------------------------------------------- |
| **Fields**             | – `_speedMph : double`  (or store distance)               |
| **Methods**            | + `Cycling(date : DateTime, minutes : int, speedMph : double)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

**Description:**  
Calculates distance from speed and time. Provides mph and pace equivalents.

---

### **Swimming : Activity**

| **Swimming : Activity** |                                                                  |
| ----------------------- | ---------------------------------------------------------------- |
| **Fields**              | – `_laps : int`                                                   |
| **Methods**             | + `Swimming(date : DateTime, minutes : int, laps : int)`  <br>+ `GetDistance() : double`  <br>+ `GetSpeed() : double`  <br>+ `GetPace() : double` |

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

back to [main](../README.md)