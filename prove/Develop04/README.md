# Unit 04 Develop: Mindfulness Program Class Diagram

## Class Diagram

---

### **Program**

| **Program** |                                                                                                       |
| ----------- | ----------------------------------------------------------------------------------------------------- |
| **Fields**  | – *(none required)*                                                                                   |
| **Methods** | + `Main(args : string[]) : void`<br>– `DisplayMenu() : void`<br>– `HandleChoice(choice : int) : void` |

**Description:**
Controls the menu, creates the activity objects, and runs them.

---

### **Activity** (Base Class)

| **Activity** |                                                                                                                                                              |
| ------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Fields**   | – `_name : string`<br>– `_description : string`<br>– `_duration : int`                                                                                       |
| **Methods**  | + `StartMessage() : void`<br>+ `EndMessage() : void`<br>+ `Spinner(seconds : int) : void`<br>+ `Countdown(seconds : int) : void`<br>+ `virtual Run() : void` |

**Description:**
Provides common behavior for all activities, including timing, animations, and intro/outro messages.

---

### **BreathingActivity**

| **BreathingActivity : Activity** |                                |
| -------------------------------- | ------------------------------ |
| **Fields**                       | – *(inherits Activity fields)* |
| **Methods**                      | + `override Run() : void`      |

**Description:**
Runs the breathing exercise, alternating between inhale/exhale messages with countdowns.

---

### **ReflectionActivity**

| **ReflectionActivity : Activity** |                                                              |
| --------------------------------- | ------------------------------------------------------------ |
| **Fields**                        | – `_prompts : List<string>`<br>– `_questions : List<string>` |
| **Methods**                       | + `override Run() : void`                                    |

**Description:**
Shows a random prompt and cycles through reflection questions with spinner pauses.

---

### **ListingActivity**

| **ListingActivity : Activity** |                                                              |
| ------------------------------ | ------------------------------------------------------------ |
| **Fields**                     | – `_prompts : List<string>`<br>– `_responses : List<string>` |
| **Methods**                    | + `override Run() : void`                                    |

**Description:**
Shows a prompt, gives a countdown, collects user list items until duration ends, then returns the count.

---

If you want, I can also add arrows (inheritance diagram), or make a clean printable version.
