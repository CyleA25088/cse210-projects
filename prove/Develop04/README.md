# Unit 04 Develop: Mindfulness Program Class Diagram

## Class Diagram

---

### **BaseActivity**

| **BaseActivity** |                                                                                          |
| ---------------- | ---------------------------------------------------------------------------------------- |
| **Fields**       | – `_name : string`<br>– `_description : string`<br>– `_prompt : string`                  |
| **Methods**      | + `BaseActivity(name : string, description : string, duration : int)
 : void`<br>+ `Spinner(seconds : int) : void`<br>+ `CountdownEvent(seconds : int) : void`<br>+ `virtual Run() : void` |

**Description:**  
Base class providing shared behavior such as spinner, countdown, and a common name/prompt/description structure.

---

### **BreathingActivity**

| **BreathingActivity : BaseActivity** |                                              |
| ------------------------------------ | -------------------------------------------- |
| **Fields**                           | – `_inTime : int`<br>– `_outTime : int`       |
| **Methods**                          | + `BreathingActivity(inTime : int, outTime : int) : void`<br>+ `override Run() : void` |

**Description:**  
Implements a guided breathing exercise using inhale/exhale timing with countdowns.

---

### **ReflectionActivity**

| **ReflectionActivity : BaseActivity** |                                                                 |
| ------------------------------------- | --------------------------------------------------------------- |
| **Fields**                            | – `_prompts : List<string>`<br>– `_questions : List<string>`     |
| **Methods**                           | + `ReflectionActivity() : void`<br>+ `override Run() : void`     |

**Description:**  
Guides the user through deep reflection by showing a random prompt and then asking reflective questions with spinner pauses until the activity duration ends.

---

### **ListingActivity**

| **ListingActivity : BaseActivity** |                                                                |
| ---------------------------------- | -------------------------------------------------------------- |
| **Fields**                         | – `_prompts : List<string>`<br>– `_responses : List<string>`    |
| **Methods**                        | + `ListingActivity() : void`<br>+ `override Run() : void`        |

**Description:**  
Shows a random prompt, gives a short countdown, then collects as many user-entered responses as possible until the duration expires. Displays the total count at the end.
