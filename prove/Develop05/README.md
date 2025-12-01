# Unit 05 Develop: Eternal Quest Program Class Diagram

## Class Diagram

---

### **Program**

| **Program** |                                                                                        |
| ----------- | -------------------------------------------------------------------------------------- |
| **Fields**  | – `_goals : List<BaseGoal>`<br>– `_score : int`                                        |
| **Methods** | + `Main(args : string[]) : void`<br>+ `DisplayMenu() : void`<br>+ `ShowScore() : void` |

**Description:**
Controls the main menu loop. Lets the user create goals, record goal events, display goal list and score, and repeat until the user quits.

---

## **BaseGoal**

| **BaseGoal** |                                                                                                                                                                   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**   | – `_name : string`<br>– `_points : int`<br>– `_isComplete : bool`                                                                                                 |
| **Methods**  | + `BaseGoal(name : string, points : int)`<br>+ `GetName() : string`<br>+ `RecordEvent() : int`<br>+ `DisplayGoal() : void`<br>+ `virtual CalculatePoints() : int` |

**Description:**
Abstract base class providing shared functionality such as storing goal name, points, completion status, recording events, and displaying goal info. Derived classes override `CalculatePoints()` for type-specific behavior.

---

## **SimpleGoal**

| **SimpleGoal : BaseGoal** |                                                                                     |
| ------------------------- | ----------------------------------------------------------------------------------- |
| **Fields**                | None (inherits all from BaseGoal)                                                   |
| **Methods**               | + `SimpleGoal(name : string, points : int)`<br>+ `override CalculatePoints() : int` |

**Description:**
A goal that can be completed once. Recording the event marks it complete and awards the defined points.

---

## **EternalGoal**

| **EternalGoal : BaseGoal** |                                                                                      |
| -------------------------- | ------------------------------------------------------------------------------------ |
| **Fields**                 | None (inherits all from BaseGoal)                                                    |
| **Methods**                | + `EternalGoal(name : string, points : int)`<br>+ `override CalculatePoints() : int` |

**Description:**
A goal that can be recorded multiple times and never completes. Each record awards points but the goal remains active indefinitely.

---

## **ChecklistGoal**

| **ChecklistGoal : BaseGoal** |                                                                                                                                                         |
| ---------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**                   | – `_targetCount : int`<br>– `_currentCount : int`<br>– `_bonusPoints : int`                                                                             |
| **Methods**                  | + `ChecklistGoal(name : string, points : int, targetCount : int, bonusPoints : int)`<br>+ `override CalculatePoints() : int`<br>+ `RecordEvent() : int` |

**Description:**
A goal that requires multiple completions. Each record awards points, and reaching the target count gives an additional bonus. Tracks current progress and displays it as “Completed X/Y times.”

---

### **Interaction Overview**

* `Program` creates and manages a **list of BaseGoal objects**.
* The user can **create new goals** (Simple, Eternal, Checklist).
* Recording an event calls the overridden `CalculatePoints()` in each derived goal type.
* The program **updates the total score** and displays the current status of all goals.
* Goals and scores can be **saved to or loaded from a file** for persistence.
