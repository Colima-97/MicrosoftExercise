# Microsoft Exercise
A company needs to fix a set of customer phone numbers wich were incorrectly stored. 

Phone numbers were mistakenly stored in the following formats:    
	
	Prefix, Area Code, Line Number
	BBBGGGRRRR
	BBB-GGG-RRRR
	
The fix intends to normalize the phone numbers as:
	
	GGG-BBB-RRRR      
	
The set of phone numbers impacted is large, so do your best to minimize additional storage.      

Implement: 

```c#
void Reformat( string[] phoneNumbers);
```
