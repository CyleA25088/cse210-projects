## 🧭 Class Diagram — Journal Program

### **Menu**

| **Menu**    |                          |
| ----------- | ------------------------ |
| **Fields**  | `_menuString : string[]` |
| **Methods** | `ProcessMenu() : int`    |

**Description:**
Handles displaying the journal menu and processing user selections.

---

### **Entry**

| **Entry**   |                                                                                                                                                              |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Fields**  | `_date : string`<br>`_prompt : string`<br>`_response : string`                                                                                               |
| **Methods** | `FillEntry(prompt : string) : void`<br>`FillEntry(date : string, prompt : string, response : string) : void`<br>`Display() : void`<br>`EntryData() : string` |

**Description:**
Stores a single journal entry, including the date, prompt, and user’s response.
Provides methods for displaying and formatting entry data.

---

### **Journal**

| **Journal** |                                                                         |
| ----------- | ----------------------------------------------------------------------- |
| **Fields**  | `_entryList : List<Entry>`<br>`_fileLocation : string`                  |
| **Methods** | `displayEntries() : void`<br>`SaveFile() : void`<br>`ReadFile() : void` |

**Description:**
Manages all journal entries and file operations such as saving and loading entries.

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
* **Menu** operates independently and only provides user input options.
