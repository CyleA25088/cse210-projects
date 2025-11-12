# Scripture Memorizer program

## Class Diagram

---

### **Scripture**

| **Scripture** |                                                      |
| ------------- | ---------------------------------------------------- |
| **Fields**    | `- _reference : Reference`<br>`- _sentence : List<Word>` |
| **Methods**   | *(none specified)*                                   |

**Description:**
Represents a scripture passage containing a reference and a list of words from the verse or verses.

---

### **Reference**

| **Reference** |                                                                                                                                     |
| ------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**    | `- _book : string[]`<br>`- _chapter : int`<br>`- _startVerse : int`<br>`- _endVerse : int`                                                  |
| **Methods**   | `+ Reference(book : string[], startVerse : int)`<br>`+ Reference(book : string[], startVerse : int, endVerse : int)`<br>`+ GetWordList()` |

**Description:**
Stores reference information for a scripture, including the book, chapter, and verse range.
Provides constructors for both single and multiple verses and can retrieve a list of words.

---

### **Word**

| **Word**    |                                                                     |
| ----------- | ------------------------------------------------------------------- |
| **Fields**  | `- _word : string`<br>`- _length : int`<br>`+ _isVisible : boolean` |
| **Methods** | `+ GetWord()`                                                       |

**Description:**
Represents an individual word in a scripture with its text, length, and visibility state.

---

### **Relationships**

* **Scripture** contains a **Reference** and a list of **Word** objects.
* **Reference** provides verse details used by **Scripture**.
* **Word** is the smallest unit within **Scripture**, representing each individual word.
