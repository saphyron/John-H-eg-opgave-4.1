# John Høeg opgave 4.1

Guide to use my program.

Before starting the program.
You need to go to each of the following controllers and change the path to what corresponds to your PC.
ConvertController.cs
FindLocationController.cs
RoadNamesController.cs

Each of these controllers are in the controller folder.
It should be quite obvious where you need to change the path. Sorry for any inconveniance this may cause.
Reason, a) lazyness, b) brainoverload, c) lack of time and desire to finish
![image](https://user-images.githubusercontent.com/30288325/227993232-bc5496bc-a687-4d02-88f8-15eb11424001.png)

After you have change the path. Run the program.

When you start the program. You should get the following page.
![image](https://user-images.githubusercontent.com/30288325/227992185-fd6e1578-b545-46f7-b074-40fb1acc110a.png)

This is just a intro page, nothing interesting at all.
The first step is to press the TXT Convert Tab. This will open a new page, if the Classfiles already exist on your pc the page loads fast and nothing happens, then console window will state that file already exist and you will need to remove them before it will generate new ones.
If files don't exist it will start to generate the 16 files that is used by the 2 rest functions, this will take between 90-350 seconds, depending on how good your PC are.
![image](https://user-images.githubusercontent.com/30288325/227994091-6cbd7497-adea-497d-9d1f-976831a8537b.png)
![image](https://user-images.githubusercontent.com/30288325/227994267-5b29f06b-6c69-4442-b6f0-ea55e76396e5.png)


The next step after the converter has converted the TXT file to JSON is to head to the Find Location Tab.
![image](https://user-images.githubusercontent.com/30288325/227994385-bb5c37ce-a8bb-42f8-91cb-eaf799925714.png)
I am not a frontend dev, this was in part one of the hardest and timeconsuming part of the project. Also I did not focus on making it look good. I have 0 interest working in frontend.
The first label, input field and button is dedicated to search for all roads that start with whatever input you write. Please note its Case Sensitive.
Example Case Mas:
![image](https://user-images.githubusercontent.com/30288325/227995012-8bc72e2e-ece2-41d4-8691-85f8e233beda.png)

The 2nd set of labels, input fields and a button is for searching for a specific road when you are using the road code and the kommune code.
Example Case Road Code = 0836 | Kommune Code = 0482
![image](https://user-images.githubusercontent.com/30288325/227995436-33601650-f16b-485b-9e03-3930960a9afe.png)

That should be the program.

Now the assignment had questions associated to it.
Is there any patterns, that I have read about that could be taking into use in my solution:
    a) I honestly forgot about any patterns in the book when I created this solution, which is most likely why I had so much trouble and spending such a undgodly amount of time on it. Total time spent over the last 6 days is roughly 42 hours.
    
Is there any pros and cons for using textfiles for integration.

  a) Apart from having the file getting moved to server and converted to a new format, not much. It was a pain in the buttocks finding out how to convert it to JSON, but after that there is more manual work than automated work. With the backend (on my machine) setup right its quite simple.
