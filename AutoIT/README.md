# AutoIT Resources

Small & Fast resource page for AutoIT

# FAQ

- https://www.autoitscript.com/autoit3/docs/
- https://www.autoitscript.com/forum/
- https://www.autoitscript.com/wiki
- https://www.autoitscript.com/wiki/SciTE4AutoIt3

# Memo

## Basics

| Type                   | Description                                                                                  |
|------------------------|----------------------------------------------------------------------------------------------|
| function()             | Function                                                                                     |
| $Variable              | Variable                                                                                     |

## Variables

| Directive              | Description                                                                                  |
|------------------------|----------------------------------------------------------------------------------------------|
| Global $variable       | Global Variable                                                                              |
| Local $variable        | Local Variable                                                                               |
| Const $variable        | Static Variable                                                                              |

## Directives

| Directive              | Description                                                                                  |
|------------------------|----------------------------------------------------------------------------------------------|
| #Comments              | Comment on one line                                                                          |
| #include               | Include a file into the script                                                               |
| #NoTrayIcon            | Hide icon                                                                                    |
| #OnAutoItStartRegister | Set up the first function that will be call when the script will start                       |
| #RequireAdmin          | Force UAC with the script                                                                    |

## Macro

Not all of them are present here...  

### Keyboard

| Macro               | Description                                                                                     |
|---------------------|-------------------------------------------------------------------------------------------------|
| @HotKeyPressed      | Last HotKey pressed                                                                             |                                                                          
| @KBLayout           | Return Language identifier constant of the keyboard                                             |                                                                                            

### Path

| Macro               | Description                                                                                     |
|---------------------|-------------------------------------------------------------------------------------------------|
| @AppDataCommonDir   | Application Data Folder Path                                                                    |                                                                                                                               
| @AppDataDir         | Romaing Folder Path                                                                             |                                                                                                                                    
| @CommonFilesDir     | Common Files Folder Path                                                                        |                                                                                                                         
| @DesktopCommonDir   | Desktop Folder Path                                                                             |
| @DesktopDir         | User Desktop Folder Path                                                                        |                                                                                                             
| @LocalAppDataDir    | Local Application Data Folder Path.                                                             |                                                                                                          
| @ProgramFilesDir    | ProgramFiles Folder Path                                                                        |                                                                                                                       
| @ScriptDir          | AutoIT Script Folder Path                                                                       |                                                      
| @ScriptFullPath     | @ScriptDir & "\" & @ScriptName                                                                  |                                                                                                                    
| @SystemDir          | System32 Folder Path                                                                            |
| @TempDir            | TEMP Folder Path                                                                                |
| @UserProfileDir     | User Profile Folder Path                                                                        |
| @WindowsDir         | Windows Folder Path                                                                             |
| @WorkingDir         | Working Directory Folder Path                                                                   |

### Machine

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @ComputerName       | Computer Name \o/                                                                            |                                                                                                                   
| @CPUArch            | Possible values "X86" 32-bit CPU - "X64" 64-bit CPU                                          |
| @OSArch             | Current Architecture used by the Operating System                                            |
| @OSBuild            | OS Build Version                                                                             |
| @OSLang             | Language currently used on the Operating System                                              |                                   
| @OSTYPE             | Give OS Type                                                                                 |
| @OSVersion          | Give OS Version :)                                                                           |

### Screen

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @DesktopDepth       | Desktop Depth (in pixel)                                                                     |                                                                                                                
| @DesktopHeight      | Desktop Height (in pixel)                                                                    |
| @DesktopRefresh     | Desktop Speed Refresh (in Hz)                                                                |                                                                                                                                      
| @DesktopWidth       | Desktop Width (in pixel)                                                                     |

### AutoIT program itself

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @AutoItPID          | Get PID of the script                                                                        |
| @AutoItVersion      | Get AutoIT Version                                                                           |
| @AutoItX64          | Check if script is running in x64 version                                                    |           
| @Compiled           | Check if script is compiled or no                                                            |                                                                             
| @ScriptLineNumber   | Current line of the executed script                                                          | 
| @ScriptName         | Script name currently used                                                                   |

### Text / Print

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @CR                 | Carriage Return                                                                              |
| @CRLF               | @CR & @LF                                                                                    |
| @LF                 | Return line                                                                                  |                                                                     
| @TAB                | Tab character                                                                                |                                                                                                                 

### Time

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @HOUR               | Current Hour (00-30)                                                                         |                                                                                                  
| @MDAY               | Day of the current month (01-31)                                                             |
| @MIN                | Current Minute (00-59)                                                                       |
| @MON                | Current Month. (01-12)                                                                       |
| @MSEC               | Current Millisecond (000-999)                                                                |                               
| @SEC                | Current Second. (00-59)                                                                      |
| @WDAY               | Current Day of the week in an integer number.  (1-7) -> Sunday to Saturday.                  |                                                                                                                         
| @YDAY               | Current Day of the year. (1-365/366).                                                        |                                                                                    
| @YEAR               | Current Year (YYYY Format)                                                                   |                                                                                                                                                                                                  
### Logon & User

| Macro               | Description                                                                                  |
|---------------------|----------------------------------------------------------------------------------------------|
| @LogonDNSDomain     | DNS Domain Logon.                                                                            |
| @LogonDomain        | Domain Logon.                                                                                |
| @LogonServer        | Server Logon                                                                                 |
| @UserName           | Username \o/                                                                                 |
