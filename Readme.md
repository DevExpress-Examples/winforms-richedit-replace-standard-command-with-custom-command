# How to replace standard XtraRichEdit command with your own custom command


<p>This example illustrates the technique used to modify the functionality of existing XtraRichEdit commands.<br />
The RichEditControl exposes the IRichEditCommandFactoryService interface that enables you to substitute default command with your own custom command. <br />
First, create a command class, inherited from the command that you've decided to replace. Override its methods. The main functionality and command specifics  is located in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressUtilsCommandsCommand_Executetopic">Execute</a> or the<strong> ExecuteCore</strong> method (the latter does not check for the command availability). <br />
Then, create a class implementing the IRichEditCommandFactoryService. You should override the CreateCommand method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. So, instead of the default command, a custom command will be used by the RichEditControl.<br />
Finally we use this class to substitute the default RichEditControl's service.</p>

<br/>


