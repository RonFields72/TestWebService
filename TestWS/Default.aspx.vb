Imports TestWS.leadcatcher.LeadCatcherService
Imports TestWS.GermanCities.OrteLookup
Imports TestWS.leadCatcherV2.LeadCatcherService


Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'This page is used to test web services
        Dim response As String
        Dim response2 As String
        Dim zipResponse As String

        'the LeadCatcherWS methods can be set to CORP/TEST in the web.config of that project
        'test leadcatcher on corp
        'response = TestLeadCatcher()

        'test leadcatcher on corptest
        'response = TestLeadCatcherWS()

        'test zip checker
        zipResponse = TestZIPCheckerWS()

        'test leadcatcher (version 3)
        'response = TestLeadCatherWSv3PROD()
        response = TestLeadCatcherWSv3TEST()

        'test public
        response2 = TestGermanCities()


        'populate text boxes
        tbZIPOutput.Visible = True
        tbZIPOutput.Text = zipResponse
        tbOutput.Visible = True
        tbOutput.Text = response
        tbGermanCities.Visible = True
        tbGermanCities.Text = response2

    End Sub

    Private Function TestLeadCatcher() As String
        Dim response As String

        'Test the LeadCatcher Web Service
        Dim srv As New leadcatcher.LeadCatcherService
        response = srv.AddLead("Ted", "Gun", "95 Maple Ave", "West Fork", "AR", "72774", "eightbits72@gmail.com", "(479) 435-3432", "FAY", "I am testing the lead catcher web service after another deploy", "Y", "JNY8675309")

        Return response

    End Function

    Private Function TestGermanCities() As String
        Dim response As String

        'Test a free publicly available web service - this one looks up German cities that start with a specified character
        Dim german As New GermanCities.OrteLookup
        response = german.OrteStartWith("L")
        Return response
    End Function

    Private Function TestLeadCatcherWS() As String
        Dim response As String = String.Empty

        Dim srv As New leadCatcherV2.LeadCatcherService
        Try
            srv.UseDefaultCredentials = True
            response = srv.AddLeadV2("Old", "Mann", "95 Maple Ave", "West Fork", "AR", "72774", "inmyday@gmail.com", "(479) 434-9999", "FAY", "I am testing the lead catcher web service AddLeadV2 with opt out flag", "Y", "JNY8675309", "Y")
        Catch ex As Exception
            response = ex.Message + " " + ex.InnerException.ToString
        End Try

       

        Return response
    End Function

    Private Function TestLeadCatherWSv3PROD() As String
        Dim response As String = String.Empty

        Dim servy As New leadcatcher.LeadCatcherService
        Try
            servy.UseDefaultCredentials = True
            response = servy.AddLeadV3("Honus", "Wagner", "100 Baseball Street", "West Fork", "AR", "72774", "ron.fields@ubh.com", "(479) 435-3432", "I am testing the lead catcher web service AddLeadV3 method that determines the office based on coords", "Y", "JNY8675309", "Y")
        Catch ex As Exception
            response = ex.Message + " " + ex.InnerException.ToString
        End Try

        Return response
    End Function

    Private Function TestZIPCheckerWS() As String
        Dim response As String = String.Empty

        Dim servy As New leadcatcher.LeadCatcherService
        Try
            servy.UseDefaultCredentials = True
            response = servy.CheckZIP("72764", "JNY8675309")
        Catch ex As Exception
            response = ex.Message + " " + ex.InnerException.ToString
        End Try

        Return response
    End Function

    Private Function TestLeadCatcherWSv3TEST() As String
        Dim response As String = String.Empty

        Dim myService As New leadCatcherV3TEST.LeadCatcherService

        Try
            myService.UseDefaultCredentials = True
            response = myService.AddLeadV3("Kurt", "Warner", "100 Football Street", "West Fork", "AR", "72774", "ron.fields@ubh.com", "(479) 435-3432", "I am testing the lead catcher web service AddLeadV3 method that determines the office based on coords", "Y", "JNY8675309", "Y")
        Catch ex As Exception
            response = ex.Message + " " + ex.InnerException.ToString
        End Try

        Return response
    End Function

End Class