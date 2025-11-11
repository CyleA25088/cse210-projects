# Unit 02 Develop: Journal Program

## Class Diagram

### **Menu**

| **Menu**    |                          |
| ----------- | ------------------------ |
| **Fields**  | `_menuString : string[]` |
| **Methods** | `ProcessMenu() : int`    |

**Description:**
Handles displaying the journal menu and processing user selections.

---

### **Entry**

| **Entry**   |                                                                                                                                                                                                         |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Fields**  | `_date : string`<br>`_prompt : string`<br>`_response : string`                                                                                                                                          |
| **Methods** | `FillEntry(prompt : string) : void`<br>`FillEntry(date : string, prompt : string, response : string) : void`<br>`Display() : void`<br>`EntryData() : string`<br>`EscapeForCsv(field : string) : string` |

**Description:**
Stores a single journal entry, including the date, prompt, and user’s response.
Provides methods for displaying, formatting, and escaping entry data safely for CSV.

---

### **Journal**

| **Journal** |                                                                                                                         |
| ----------- | ----------------------------------------------------------------------------------------------------------------------- |
| **Fields**  | `_entryList : List<Entry>`<br>`_fileLocation : string`                                                                  |
| **Methods** | `displayEntries() : void`<br>`SaveFile() : void`<br>`ReadFile() : void`<br>`ParseCsvLine(line : string) : List<string>` |

**Description:**
Manages all journal entries and file operations such as saving and loading entries in **CSV format**.
Automatically escapes commas, quotes, and newlines for CSV compliance, and replaces current entries when reading from file.

---

### **Program**

| **Program** |                                                                   |
| ----------- | ----------------------------------------------------------------- |
| **Fields**  | `_questions : string[]`                                           |
| **Methods** | `ChooseRandomPrompt() : string`<br>`Main(args : string[]) : void` |

**Description:**
Controls the flow of the entire application.
Creates and connects the `Menu`, `Journal`, and `Entry` objects.

---

### **Relationships**

* **Program** creates and manages `Menu` and `Journal`.
* **Journal** manages multiple `Entry` objects.
* **Menu** operates independently and provides user input options.
* **Entry** handles its own formatting and data conversion for file I/O.
