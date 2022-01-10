# **Planning for LoreLib**
###### As with any of my works, ^ parameter ^ means an optional parameter
## **Contents:**
***
- **IMentionable** : _interface_
  - **mentionIndex** { get; } : MentionIndex  
  - **sourceIndex** { get; } : SourceIndex
  - **Mention(ISource,  ^string)** : void  
    Mentions the object and gives optional notes
***
- **ISource** : _interface_
  - **mentions** { get; } : MentionList
***
- **Party** : _class_  : IMentionable  
  A character or thing involved in something.   
  **Fields:**
  - Name : _string_ => denotes the mentions in text documents for parsing
  - 
  **Methods:**
  - Mention(string,string) : void  
    Adds the information to the party involved.
***
- **Affiliation** : _class_  : IMentionable, Party  
  A mentionable group of parties that might function as a group.
  - d
***
- **Mention** : _struct_  
  Meant to be a way to organize mentions of a party or affiliation in any way
  - Structure as value tuple : (ISource source, string notes = "")
  - d
***
- **MentionType** : _enum_  
  Meant to organize the mentions between types
***
- **MentionIndex** : _class_ : List of type Mention  
  summary
  - d
***
- **SourceIndex** : _class_ : List of type ISource