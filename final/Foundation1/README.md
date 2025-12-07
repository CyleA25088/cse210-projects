### **Video** (Program 1: Abstraction with YouTube Videos)

| **Video** |                                                                                                 |
| --------- | ----------------------------------------------------------------------------------------------- |
| **Fields**  | – `_title : string`  <br>– `_author : string`  <br>– `_lengthSeconds : int`  <br>– `_comments : List<Comment>` |
| **Methods** | + `Video(title : string, author : string, lengthSeconds : int)`  <br>+ `AddComment(comment : Comment) : void`  <br>+ `GetCommentCount() : int`  <br>+ `DisplayVideoInfo() : void` |

**Description:**  
Stores video info and a list of comments. Returns the number of comments and can list them.

---

### **Comment**

| **Comment** |                                                            |
| ----------- | ---------------------------------------------------------- |
| **Fields**  | – `_name : string`  <br>– `_text : string`                |
| **Methods** | + `Comment(name : string, text : string)`  <br>+ `GetCommentName() : string`  <br>+ `GetCommentText() : string` |

**Description:**  
Represents a single comment with author name and text.

---

### **Program**

| **Program** |                                                                                       |
| ---------------- | ------------------------------------------------------------------------------------- |
| **Fields**       | – `_videos : List<Video>`                                                             |
| **Methods**      | + `Main(args : string[]) : void`  <br>- `CreateSampleVideos() : void`  <br>- `DisplayAllVideos() : void` |

**Description:**  
Creates 3–4 videos. Adds 3–4 comments each. Iterates and displays each video's data.


back to [main](../README.md)