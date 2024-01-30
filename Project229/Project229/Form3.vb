'To create a program with speech recognition you need to add the System.Speech library.
Imports System.Data.SqlClient
Imports System.Speech
Imports System.Speech.Recognition

Public Class Form3
    Dim cnn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amaal\Desktop\Visual Programming_29\finle project\Project229\Project229\Database1.mdf;Integrated Security=True "
    Dim conn As SqlConnection = New SqlConnection(cnn)
    Dim SAPI
    Dim level2 As Integer = Form1.level

    'Create the first global variable MyVoice to recognise the new voice each time a person speaks
    Dim WithEvents MyVoice As New Recognition.SpeechRecognitionEngine
    Private currentLetter As String = "A"

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If level2 = 2 Then
            PicB.Visible = True
            currentLetter = "B"
        End If
        If level2 = 3 Then
            PicB.Visible = True
            PicC.Visible = True
            currentLetter = "C"
        End If
        If level2 = 4 Then
            PicB.Visible = True
            PicC.Visible = True
            PicApple.Visible = True
            currentLetter = "D"
        End If
        If level2 = 5 Then
            PicB.Visible = True
            PicC.Visible = True
            PicApple.Visible = True
            PicBook.Visible = True
            currentLetter = "E"
        End If
        If level2 = 6 Then
            PicB.Visible = True
            PicC.Visible = True
            PicApple.Visible = True
            PicBook.Visible = True
            PicCat.Visible = True
            currentLetter = "F"
        End If

        'activate the default audio device "Mic"
        MyVoice.SetInputToDefaultAudioDevice()

        'Create a new grammar object( MyGrammar) (Speech Recognition Grammar Specification (SRGS))
        Dim MyGrammar As New Recognition.SrgsGrammar.SrgsDocument

        'Create a new rule object (MyWordsRule)
        Dim MyWordsRule As New Recognition.SrgsGrammar.SrgsRule("words")

        'Creates a new one-of object with the set of words
        Dim MyWords As New Recognition.SrgsGrammar.SrgsOneOf("A", "B", "C", "D", "E", "F")

        '(Add the words I speak onto the system')'Adds the MyWords object to the 
        'MyWordsRule rule using the Add() method of the SrgsRule class.
        MyWordsRule.Add(MyWords)

        '(Add the MyWordRule onto the system)'Adds the MyWordsRule rule to 
        'the grammar using the Rules property of the SrgsGrammar class.
        MyGrammar.Rules.Add(MyWordsRule)

        '(The location to MyWordRule)'Sets the root rule of the grammar to the MyWordsRule rule
        MyGrammar.Root = MyWordsRule

        '(When you hear my voice, LoadGrammar)'Loads the grammar into the speech recognition engine
        MyVoice.LoadGrammar(New Recognition.Grammar(MyGrammar))

        '(recognise my voice on form load)' Starts the speech recognition engine.
        MyVoice.RecognizeAsync()
    End Sub


    'recognise my voice every time I speak
    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles MyVoice.RecognizeCompleted
        MyVoice.RecognizeAsync()
    End Sub

    'recognise my voice and if the case exists, execute the procedure
    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles MyVoice.SpeechRecognized
        SAPI = CreateObject("SAPI.spvoice")
        Dim letter As String = e.Result.Text

        If letter = currentLetter Then
            Select Case currentLetter
                Case "A"
                    SAPI.Speak("excellent A")
                    PicB.Visible = True
                    currentLetter = "B"
                    level2 += 1
                Case "B"
                    SAPI.Speak("excellent B")
                    PicC.Visible = True
                    currentLetter = "C"
                    level2 += 1
                Case "C"
                    SAPI.Speak("excellent C")
                    PicApple.Visible = True
                    currentLetter = "D"
                    level2 += 1
                Case "D"
                    SAPI.Speak("excellent D")
                    PicBook.Visible = True
                    currentLetter = "E"
                    level2 += 1
                Case "E"
                    SAPI.Speak("excellent E")
                    PicCat.Visible = True
                    currentLetter = "F"
                    level2 += 1
                Case "F"
                    SAPI.Speak("excellent F")
                    btnLevel.Visible = True
                    level2 += 1
            End Select
        Else
            SAPI.Speak("Please try again.")
        End If
    End Sub
    Private Sub btnLevel_Click(sender As Object, e As EventArgs) Handles btnLevel.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        conn.Open()
        Dim cmd As SqlCommand = New SqlCommand("update Information set level='" + level2.ToString + "' where Email= '" + Form1.userEmail + "'and Password = '" + Form1.userPass + "'", conn)
        Dim searchData As DataTable = New DataTable()
        cmd.ExecuteNonQuery()
        conn.Close()
        Me.Close()
    End Sub
End Class

