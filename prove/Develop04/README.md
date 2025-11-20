# Unit 04 Develop: Mindfulness Program Class Diagram

## Class Diagram

---

### **Program**

| **Program** |                                                                                                             |
| ----------- | ----------------------------------------------------------------------------------------------------------- |
| **Fields**  | – `_activities : List<BaseActivity>`                                                                        |
| **Methods** | + `Main(args : string[]) : void`<br>+ `DisplayMenu() : void`<br>+ `RunSelectedActivity(index : int) : void` |

**Description:**
Entry point of the application. Displays a menu for the user to select an activity, instantiates the selected activity, and calls its `Run()` method.


---

### **BaseActivity**

| **BaseActivity** |                                                                                                                                                                                           |
| ---------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**       | – `_name : string`<br>– `_description : string`<br>– `_duration : int`                                                                                                                    |
| **Methods**      | + `BaseActivity(name : string, description : string, duration : int) : void`<br>+ `Spinner(seconds : int) : void`<br>+ `CountdownEvent(seconds : int) : void`<br>+ `virtual Run() : void` |

**Description:**
Base class providing shared behavior such as spinner, countdown, and description/name handling.

---

### **BreathingActivity**

| **BreathingActivity : BaseActivity** |                                                                                                                                             |
| ------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**                           | – `_inTime : int`<br>– `_outTime : int`                                                                                                     |
| **Methods**                          | + `BreathingActivity(name : string, description : string, duration : int, inTime : int, outTime : int) : void`<br>+ `override Run() : void` |

**Description:**
Implements a guided breathing exercise using inhale/exhale timing with countdowns.

---

### **ReflectionActivity**

| **ReflectionActivity : BaseActivity** |                                                                                                                 |
| ------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| **Fields**                            | – `_prompts : List<string>`<br>– `_questions : List<string>`                                                    |
| **Methods**                           | + `ReflectionActivity(name : string, description : string, duration : int) : void`<br>+ `override Run() : void` |

**Description:**
Guides the user through deep reflection by showing a random prompt and then asking reflective questions with spinner pauses until the activity duration ends.

---

### **ListingActivity**

| **ListingActivity : BaseActivity** |                                                                                                              |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------------ |
| **Fields**                         | – `_prompts : List<string>`<br>– `_responses : List<string>`                                                 |
| **Methods**                        | + `ListingActivity(name : string, description : string, duration : int) : void`<br>+ `override Run() : void` |

**Description:**
Shows a random prompt, gives a short countdown, then collects as many user-entered responses as possible until the duration expires. Displays the total count at the end.






