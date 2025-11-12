# Unit 03 Develop: Scripture Memorizer program

## Class Diagram

### **Program**

| **Program** |                                                               |
| ----------- | ------------------------------------------------------------- |
| **Fields**  | `- _scripture : Scripture`                                    |
| **Methods** | `+ Main() : void`<br>`+ Display() : void`<br>`+ Run() : void` |

**Description**
The main class that controls the flow of the scripture memorization program. It handles user interaction, updates the display, and manages the scripture object.

---

### **Scripture**

| **Scripture** |                                                                                                                                                                    |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Fields**    | `- _reference : Reference`<br>`- _words : List<Word>`                                                                                                              |
| **Methods**   | `+ Scripture(reference : Reference, text : string)`<br>`+ HideRandomWords(count : int) : void`<br>`+ GetDisplayText() : string`<br>`+ IsCompletelyHidden() : bool` |

**Description**
Stores the scripture text and its reference. Responsible for hiding and revealing words as the user progresses through memorization.

---

### **Reference**

| **Reference** |                                                                                                                                                                  |
| ------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**    | `- _book : string`<br>`- _chapter : int`<br>`- _startVerse : int`<br>`- _endVerse : int`                                                                         |
| **Methods**   | `+ Reference(book : string, chapter : int, verse : int)`<br>`+ Reference(book : string, chapter : int, start : int, end : int)`<br>`+ GetDisplayText() : string` |

**Description**
Represents the location of a scripture in the standard works (e.g., “John 3:16” or “Proverbs 3:5–6”). Provides methods to format and display the reference.

---

### **Word**

| **Word**    |                                                                                                                             |
| ----------- | --------------------------------------------------------------------------------------------------------------------------- |
| **Fields**  | `- _text : string`<br>`- _isHidden : bool`                                                                                  |
| **Methods** | `+ Word(text : string)`<br>`+ Hide() : void`<br>`+ Show() : void`<br>`+ GetDisplayText() : string`<br>`+ IsHidden() : bool` |

**Description**
Represents a single word in the scripture text. Keeps track of whether the word is hidden or visible and provides display functionality.

---

### **Relationships**

* **Program** creates and manages the `Scripture` object and controls the memorization process.
* **Scripture** manages its own `Reference` and a collection of `Word` objects.
* **Reference** provides formatted citation data used by `Scripture`.
* **Word** operates independently, tracking and updating its visibility state within the `Scripture`.
