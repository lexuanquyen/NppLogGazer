# NppLogGazer

## Description

**NppLogGazer** is a Notepad++ plugin with fancy search features, providing fast and convenient searching especially for log analysis. It contains two separate plugins: **QuickSearchPanel** for managing and searching frequently used keywords, and **PatternTracer** for tracking keywords sequence.


## How to install

Copy the **NppLogGazer.dll** to the **plugins** folder in your Notepad++ directory.

**Important Note:** NppQuickSearchPanel only support the **Unicode** version of Notepad++.


## QuickSearchPanel

![screenshot][quick_search_panel_screenshot]

### Features

- Save your frequently used keywords in a list.
- Click on keyword in the list to search.
- Provide multiple search options and regular expression support.

### How to use
Open up Notepad++, click the ![pluginicon][quick_search_panel_icon]**Show QuickSearchPanel** button in the toolbar, or use menu **Plugins / NppLogGazer / Show QuickSearchPanel**.

- Input keyword in the text box. Select ![reg_exp][reg_exp_icon]**Regular Expression** if it is a regular expression. Click ![add][add_icon]**Add** button to add it to the list.
- <kbd>**Click**</kbd> on the keyword in the list to search forward. <kbd>**Shift**</kbd> + <kbd>**Click**</kbd> to search backward. Search options: ![match_word][match_word_icon]**Match Word**, ![match_case][match_case_icon]**Match Case** and ![wrap_search][wrap_search_icon]**Wrap Search**.
- <kbd>**Ctrl**</kbd> + <kbd>**Click**</kbd> on the keyword to launch Notepad++'s "Find" dialog with selected keyword pasted in "Find what" automatically. (Note: The "Regular expression" in Notepad++'s Find dialog won't be selected automatically, due to lacking of API support.)
- Use ![delete][delete_icon]**Delete** button to remove the selected keyword. You can also change the order of selected keyword by using ![move_up][move_up_icon]**Move Up** and ![move_down][move_down_icon]**Move Down**.
- Use ![open][open_icon]**Open...**/![save][save_icon]**Save As...** to import / export current keywords list.
- Use ![filter][filter_icon]**Filter** to filter given keyword in the list.


## PatternTracer

![screenshot][pattern_tracer_screenshot]

### Features

- Build keyword pattern and track them down in the document by one click.
- Save your patterns in a list.
- Provide multiple search options and regular expression support.

### How to use

Open up Notepad++, click the ![plugin_icon][pattern_tracer_icon]**Show PatternTracer** button in the toolbar, or use menu **Plugins / NppLogGazer / Show PatternTracer**.

- Input pattern in the text box. A pattern is a keyword list. Each keyword takes one line and will be searched in the same order as they are positioned in the list. Select ![reg_exp][reg_exp_icon]**Regular Expression** if you use regular expression.
- Select search options: ![match_word][match_word_icon]**Match Word** and ![match_case][match_case_icon]**Match Case**.
- Click ![search][search_icon]**Search** to search the pattern in the current document.
- Use ![add][add_icon]**Add** to add current pattern to the list and ![delete][delete_icon]**Delete** to remove the selected pattern. You can also change the order of selected pattern item by using ![move_up][move_up_icon]**Move up** and ![move_down][move_down_icon]**Move down**.
- Use ![open][open_icon]**Open...**/![save][save_icon]**Save As...** to import / export current keywords list.


## How to build

Build with Visual Studio 2013. If you encounter a "The system cannot find the file specified" error when building the project, add the location of **NETFX Tools** to your **Path** environment variable.

For 64-bit system and Visual Studio 2013, the typical location of **NETFX Tools** is
```
C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools
```

For 32-bit system, the typical location is
```
C:\Program Files\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools
```


## Credits

- [NppPlugin.NET.v0.6], the C# Notepad++ plugin template is brought to you by ufo-pu55y.
- The nice toolbar icons come from [famfamfam.com], under [Creative Commons Attribution 3.0 License].


## About Notepad++

Notepad++ is a free (as in "free speech" and also as in "free beer") source code editor and Notepad replacement that supports several languages. Running in the MS Windows environment, its use is governed by GPL License.
For more information, please visit the [official site].


[pattern_tracer_screenshot]: Images/pattern_tracer_screenshot.png
[quick_search_panel_screenshot]: Images/quick_search_panel_screenshot.png
[pattern_tracer_icon]: Images/Icons/pattern_tracer.png
[reg_exp_icon]: Images/Icons/reg_exp.png
[match_word_icon]: Images/Icons/match_word.png
[match_case_icon]: Images/Icons/match_case.png
[wrap_search_icon]: Images/Icons/wrap_search.png
[search_icon]: Images/Icons/search.png
[add_icon]: Images/Icons/add.png
[delete_icon]: Images/Icons/delete.png
[move_up_icon]: Images/Icons/move_up.png
[move_down_icon]: Images/Icons/move_down.png
[open_icon]: Images/Icons/open.png
[save_icon]: Images/Icons/save.png
[quick_search_panel_icon]: Images/Icons/quick_search_panel.png
[filter_icon]: Images/Icons/filter.png

[NppPlugin.NET.v0.6]: http://sourceforge.net/projects/sourcecookifier/files/other%20plugins/
[famfamfam.com]: http://www.famfamfam.com/
[Creative Commons Attribution 3.0 License]: http://creativecommons.org/licenses/by/3.0/
[official site]: https://notepad-plus-plus.org/
