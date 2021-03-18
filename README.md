# Unity-WebGL-Alert
 
## Usage
```.cs
WebGLAlert.ShowAlert(alertTextField.text);

bool confirm = WebGLAlert.ShowConfirm(confirmTextField.text).ToString();

string prompt = WebGLAlert.ShowPrompt(promptTextField.text);
```