Public Class frmHelpTopics

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label9.Text = "Connecting to other users(Recipient)"
        txthelp.Text = vbCrLf + "1. Input the IP Address or the Computer Name of the Recipient PC into the Recipient PC Textbox" + vbCrLf + vbNewLine + "2. Click(the) 'Connect' Button" + vbCrLf + vbNewLine + "3. If an error message is displayed, read the message, close the message and re-type the Host-IP or Host-Name" + vbCrLf + vbNewLine + "4. Click the Connect button again to connect to the PC" + vbCrLf + vbNewLine + "5. If the connection is successful, the chat box will be enabled (receive Focus), the recipient will recieve a notification of your connection to his/her PC and you can start chatting"

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label9.Text = "Sending a message to a connected user"
        txthelp.Text = vbCrLf + "1. Once you are connected to a user, place your cursor in the Chat box and type your message" + vbCrLf + vbNewLine + "2. Click the send button and the message will be delivered to the recipient's message screen" + vbCrLf + vbNewLine + "3. A copy of the sent message will also be displayed on your message screen"

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Label9.Text = "Chatting with a connected user"
        txthelp.Text = vbCrLf + "1. After sending a message to the recipient, the user can choose to send you a feedback which will also be displayed on your chat screen" + vbCrLf + vbNewLine + "2. Once you receive the feedback, you can then send more messages hence, you are chatting with the connected user"

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label9.Text = "Logging out of a chat session"
        txthelp.Text = vbCrLf + "1. While chatting with a connected user, click on the Options Menu" + vbCrLf + vbNewLine + "2. Select and click Logout sub-menu" + vbCrLf + vbNewLine + "3. A message box will be displayed on your screen saying you have logged out of the chat Session hence you are automatically looged out and cannot chat with any user until you login again"
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Label9.Text = "Re-logging in to the chat environment"
        txthelp.Text = vbCrLf + "1. Click on the Options Menu" + vbCrLf + vbNewLine + "2. choose the Login sub-menu" + vbCrLf + vbNewLine + "3. The Startup Screen is displayed asking for your name" + vbCrLf + vbNewLine + "4. Input your name and click OK button" + vbCrLf + vbNewLine + "5. You have successfully logged in and ready to connect"
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Label9.Text = "Saving a chat discussion"
        txthelp.Text = vbCrLf + "1. Click on the File Menu" + vbCrLf + vbNewLine + "2. Choose Save Chat sub-menu" + vbCrLf + vbNewLine + "3. On the appearing dialog box, choose which folder/directory on the PC to save your conversations into" + vbCrLf + vbNewLine + "4. Type the FileName to save the conversations with" + vbCrLf + vbNewLine + "5. The default file format will be RTF(Rich Text File) but you can choose to save as Text or Word Document(file)" + vbCrLf + vbNewLine + "6. Click Save button"
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label9.Text = "Open a saved chat discussion"
        txthelp.Text = vbCrLf + "1. Click on File Menu" + vbCrLf + vbNewLine + "2. Choose Open Saved Chat sub-menu" + vbCrLf + vbNewLine + "3. Browse to the location of the file you want to open (.rtf, .txt, .doc files)" + vbCrLf + vbNewLine + "4. click on the located file and click Open button" + vbCrLf + vbNewLine + "5. The message is opened on a seprate screen from the chat module" + vbCrLf + vbNewLine + "6. You can close the opened message after reading or open another saved message"
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Label9.Text = ""
        txthelp.Text = vbCrLf + "Browse IPChat Help..." + vbCrLf + vbNewLine + "Click on the Help Topics for guidelines using this application."
    End Sub

    Private Sub frmHelpTopics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class