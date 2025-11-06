## 🧭 Class Diagram — Journal Program

### **Menu**

+---------------------------+
|          Menu             |
+---------------------------+
| - _menuString : string[]  |
+---------------------------+
| + ProcessMenu() : int     |
+---------------------------+


**Description:**
Handles displaying the journal menu and processing user selections.

---

### **Entry**

+--------------------------------------------+
|                  Entry                     |
+--------------------------------------------+
| - _date : string                           |
| - _prompt : string                         |
| - _response : string                       |
+--------------------------------------------+
| + FillEntry(prompt : string) : void        |
| + FillEntry(date : string, prompt : string, response : string) : void |
| + Display() : void                         |
| + EntryData() : string                     |
+--------------------------------------------+

**Description:**
Stores a single journal entry, including the date, prompt, and user’s response.
Provides methods for displaying and formatting entry data.

---

### **Journal**

+---------------------------------------------+
|                  Journal                    |
+---------------------------------------------+
| + _entryList : List<Entry>                  |
| + _fileLocation : string                    |
+---------------------------------------------+
| + displayEntries() : void                   |
| + SaveFile() : void                         |
| + ReadFile() : void                         |
+---------------------------------------------+

**Description:**
Manages all journal entries and file operations such as saving and loading entries.

---

### **Program**

+---------------------------------------------+
|                  Program                    |
+---------------------------------------------+
| - _questions : string[]                     |
+---------------------------------------------+
| + ChooseRandomPrompt() : string             |
| + Main(args : string[]) : void              |
+---------------------------------------------+

**Description:**
Controls the flow of the entire application.
Creates and connects the `Menu`, `Journal`, and `Entry` objects.

---

* **Program** creates and manages `Menu` and `Journal`.
* **Journal** manages multiple `Entry` objects.
* **Menu** operates independently and only provides user input options.