<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611024/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2224)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to Replace Standard Command with Custom Command

This example illustrates the technique used to modify the functionality of existing RichEdit commands.

## Implementation Details

The RichEditControl exposes the [IRichEditCommandFactoryService](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Services.IRichEditCommandFactoryService) interface that enables you to substitute the default command with a custom command.

1. Create a command class, inherited from the command that you've decided to replace. Override its methods. The main functionality and command specifics is located in the [Execute](https://docs.devexpress.com/CoreLibraries/DevExpress.Utils.Commands.Command.Execute) or the `ExecuteCore` method (the latter does not check for the command availability).

2. Create a [IRichEditCommandFactoryService](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Services.IRichEditCommandFactoryService) implementation. Override the [CreateCommand](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Services.IRichEditCommandFactoryService.CreateCommand(DevExpress.XtraRichEdit.Commands.RichEditCommandId)) method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. So, instead of the default command, a custom command is used by the RichEditControl.

Finally we use this class to substitute the default RichEditControl's service.

## Files to Review

* [Form1.cs](./CS/CustomCommand/Form1.cs) (VB: [Form1.vb](./VB/CustomCommand/Form1.vb))

## Documentation

* [Commands in Rich Text Editor](https://docs.devexpress.com/WindowsForms/9328/controls-and-libraries/rich-text-editor/commands)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-replace-standard-command-with-custom-command&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-replace-standard-command-with-custom-command&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
