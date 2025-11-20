# Unit 04 Develop: Mindfulness Program Class Diagram

## Class Diagram

---

### **Program**

| **Program** |                                                              |
| ----------- | ------------------------------------------------------------ |
| **Fields**  | – `_activities : List<BaseActivity>`                         |
| **Methods** | + `Main(args : string[]) : void`<br>+ `DisplayMenu() : void` |

**Description:**
Controls the main menu loop. Lets the user select an activity, runs it, and repeats until the user quits.

---

## **BaseActivity**

| **BaseActivity** |                                                                                                                                                                                                                                                                                                       |
| ---------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**       | – `_name : string`<br>– `_description : string`<br>– `_duration : int`                                                                                                                                                                                                                                |
| **Methods**      | + `BaseActivity(name : string, description : string)`<br>+ `GetName() : string`<br>+ `Spinner(seconds : int) : void`<br>+ `CountdownEvent(seconds : int) : void`<br>+ `DisplayTitleDescription() : void`<br>+ `AskForDuration() : void`<br>+ `ShowEndingMessage() : void`<br>+ `virtual Run() : void` |

**Description:**
Abstract base class providing shared functionality such as displaying the title/description, prompting for duration, spinner animation, countdown, and ending message.

---

## **BreathingActivity**

| **BreathingActivity : BaseActivity** |                                                                                                                                   |
| ------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**                           | – `_inTime : int`<br>– `_outTime : int`                                                                                           |
| **Methods**                          | + `BreathingActivity(inTime : int, outTime : int)`<br>+ `override Run() : void`<br>+ `BreathingProgressBar(seconds : int) : void` |

**Description:**
Guides the user through timed inhale/exhale cycles using a visual progress bar until the selected duration expires.

---

## **ReflectionActivity**

| **ReflectionActivity : BaseActivity** |                                                              |
| ------------------------------------- | ------------------------------------------------------------ |
| **Fields**                            | – `_prompts : List<string>`<br>– `_questions : List<string>` |
| **Methods**                           | + `ReflectionActivity()`<br>+ `override Run() : void`        |

**Description:**
Shows a random reflective prompt, waits for the user to prepare, counts down, then repeatedly displays reflective questions with a spinner until time runs out.

---

## **ListingActivity**

| **ListingActivity : BaseActivity** |                                                     |
| ---------------------------------- | --------------------------------------------------- |
| **Fields**                         | – `_questions : List<string>`<br>– `_rand : Random` |
| **Methods**                        | + `ListingActivity()`<br>+ `override Run() : void`  |

**Description:**
Picks a random question prompt, counts down, then collects as many user-typed responses as possible within the duration and reports the total count.
