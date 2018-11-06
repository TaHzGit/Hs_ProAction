Imports System.Data.SqlClient
Imports System.Configuration


Public Class Autodata_Promotion


    Dim conRE As String = ConfigurationManager.ConnectionStrings("DBRE_ConnectionString").ConnectionString
    Dim conRT As String = ConfigurationManager.ConnectionStrings("DBRT_ConnectionString").ConnectionString
    Dim conPY As String = ConfigurationManager.ConnectionStrings("DBPY_ConnectionString").ConnectionString
    Dim conPK As String = ConfigurationManager.ConnectionStrings("DBPK_ConnectionString").ConnectionString
    Dim conSW As String = ConfigurationManager.ConnectionStrings("DBSW_ConnectionString").ConnectionString
    Dim conNR As String = ConfigurationManager.ConnectionStrings("DBNR_ConnectionString").ConnectionString
    Dim conHR As String = ConfigurationManager.ConnectionStrings("DBHR_ConnectionString").ConnectionString

    Dim ConHs As String = String.Empty
    Dim srv As String = String.Empty

    Dim at As Integer = 6910

    Protected Function ConSrv(ByVal brn As String) As String
        ConHs = ""
        If brn.Contains("HSRE") Then
            ConHs = conRE
        ElseIf brn.Contains("HSRT") Then
            ConHs = conRT
        ElseIf srv.Contains("HSPK") Then
            ConHs = conPK
        ElseIf brn.Contains("HSPY") Then
            ConHs = conPY
        ElseIf brn.Contains("HSSW") Then
            ConHs = conSW
        ElseIf brn.Contains("HSNR") Then
            ConHs = conNR
        End If
        Return ConHs
    End Function




    Private Sub Autodata_Promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        at = at - 1
        lbx1.Text = at
        'HSNR
        'If at = 6505 Then
        '    checkDataCp(conNR,'HSNR')
        'End If
        'If at = 6470 Then
        '    checkDataHt(conNR,'HSNR')
        'End If


        'HSRT
        If at = 6905 Then
            checkDataHt("HSRT")
            ' checkDataCp("HSRT")
        End If
        If at = 6700 Then
            checkDataHt("HSRT")
        End If





        'HSPY
        If at = 6509 Then
            checkDataCp("HSPY")
        End If
        If at = 6209 Then
            checkDataHt("HSPY")
        End If




        'HSSW
        If at = 6009 Then
            checkDataCp("HSSW")
        End If
        If at = 5900 Then
            checkDataHt("HSSW")
        End If


        'HSPK
        If at = 5909 Then
            checkDataCp("HSPK")
        End If
        If at = 54509 Then
            checkDataHt("HSPK")
        End If


        'HSRE
        If at = 4909 Then
            checkDataCp("HSRE")
        End If
        If at = 4509 Then
            checkDataHt("HSRE")
        End If


        'HSNR
        If at = 3000 Then
            checkDataCp("HSNR")
        End If
        If at = 1900 Then
            checkDataHt("HSNR")
        End If

        'If at = 3000 Then
        '    '  Application.Exit()
        'End If
    End Sub


    Private Sub checkDataCp(ByVal srv As String)

        Dim dtcpn As New DataTable

        Dim sqlQrycpn As String



        sqlQrycpn = "INSERT INTO HS101.dbo.Pro_Action(a_skucode,a_gdscode,a_typepro ,a_procode,a_proname,a_starttime,a_endtime,a_prodetail,a_bndcode,a_remark,a_update,a_srv)
SELECT SKUBUY.SKU_CODE,  GOODSBUY.GOODS_CODE, '', ARCAMPAIGN.ARCPGN_CODE, ARCAMPAIGN.ARCPGN_NAME, CONVERT(nvarchar,CONVERT(date,ARCAMPAIGN.ARCPGN_FM_DATE)) + ' ' + CONVERT(nvarchar,CONVERT(time,ARCAMPAIGN.ARCPGN_FM_TIME),120) startdate, CONVERT(nvarchar,CONVERT(date,ARCAMPAIGN.ARCPGN_TO_DATE)) + ' ' + CONVERT(nvarchar,CONVERT(time,ARCAMPAIGN.ARCPGN_TO_TIME),120) enddate,ARCCMNT_COMMENT, BRAND.BRN_CODE, '',CONVERT(smalldatetime, GETDATE(),120),'" + srv + "' FROM ARCAMPAIGN LEFT OUTER JOIN ARCBUY ON ARCBUY_ARCPGN=ARCPGN_KEY  LEFT OUTER JOIN GOODSMASTER GOODSBUY   ON GOODSBUY.GOODS_KEY = ARCBUY.ARCBUY_GOODS  LEFT OUTER JOIN SKUMASTER SKUBUY    ON SKUBUY.SKU_KEY=GOODSBUY.GOODS_SKU LEFT OUTER JOIN  UOFQTY  ON GOODS_UTQ=UTQ_KEY LEFT OUTER JOIN ARCCOMMENT  ON ARCCMNT_ARCPGN=ARCPGN_KEY left join ( SELECT  * FROM [dbo].[ARCFREE] af  left join  GOODSMASTER g on af.ARCFREE_GOODS = g.GOODS_KEY) af on af.ARCFREE_ARCPGN  = ARCAMPAIGN.ARCPGN_KEY  LEFT OUTER JOIN BRAND BRAND ON SKUBUY.SKU_BRN=BRAND.BRN_KEY     WHERE   DATEDIFF(day, ARCPGN_FM_DATE ,getdate()) = 0  AND LEN(ARCPGN_CODE) <> 5     ORDER BY ARCAMPAIGN.ARCPGN_FM_DATE"

        txt0.Text = sqlQrycpn
        Try

            Using conn As New SqlConnection(ConSrv(srv))
                Dim cmd As SqlCommand = New SqlCommand(sqlQrycpn, conn)
                conn.Open()
                cmd.CommandTimeout = 3500
                cmd.ExecuteNonQuery()
                'lbSrv.Text += ex.ToString
                conn.Close()
            End Using
            Label1.Text += " cm:" + srv
        Catch ex As Exception
            txt0.Text = ex.ToString + "___" + sqlQrycpn
            Console.Write(sqlQrycpn)
        End Try


    End Sub


    Private Sub checkDataHt(ByVal srv As String)
        Dim dthtp As New DataTable




        Dim sqlChkHtp As String
        Dim sqlQryHtp As String

        '   sqlChkHtp = "Select  * From HOTPRICE Where DateDiff(Day, HOT_FM_DATE, getdate()) <= 365"

        sqlQryHtp = " INSERT INTO HS101.dbo.Pro_Action(a_skucode,a_gdscode,a_typepro ,a_procode,a_proname,a_starttime,a_endtime,a_prodetail,a_proprice,a_bndcode,a_remark,a_update,a_srv)
SELECT SKUMASTER.SKU_CODE, GOODSMASTER.GOODS_CODE,'', HOTPRICE.HOT_CODE,HOTPRICE.HOT_NAME,CONVERT(nvarchar,CONVERT(date,HOTPRICE.HOT_FM_DATE)) + ' ' + CONVERT(nvarchar,CONVERT(time,HOTPRICE.HOT_FM_TIME),120) startdate,CONVERT(nvarchar,CONVERT(date,HOTPRICE.HOT_TO_DATE)) + ' ' + CONVERT(nvarchar,CONVERT(time,HOTPRICE.HOT_TO_TIME),120) enddate,ARPRICETAB.ARPRB_NAME,ARPLU.ARPLU_U_PRC,BRAND.BRN_CODE,'',CONVERT(smalldatetime, GETDATE(),120),'" + srv + "' FROM ARPRICETAB,  GOODSMASTER,  ARPLU, SKUMASTER, ICCAT, ICDEPT, BRAND, PRICETAG, UOFQTY, HOTSCOPE RIGHT JOIN HOTPRICE ON HOTSCOPE.HOTS_HOT=HOTPRICE.HOT_KEY  WHERE HOTPRICE.HOT_ARPRB = ARPRICETAB.ARPRB_KEY AND ARPLU.ARPLU_GOODS = GOODSMASTER.GOODS_KEY AND ARPLU.ARPLU_ARPRB = ARPRICETAB.ARPRB_KEY AND GOODSMASTER.GOODS_SKU = SKUMASTER.SKU_KEY  AND SKUMASTER.SKU_ICCAT=ICCAT.ICCAT_KEY  AND SKUMASTER.SKU_ICDEPT=ICDEPT.ICDEPT_KEY   AND SKUMASTER.SKU_BRN=BRAND.BRN_KEY   AND ARPLU.ARPLU_TAG=PRICETAG.TAG_KEY AND SKUMASTER.SKU_S_UTQ = UOFQTY.UTQ_KEY
 AND DATEDIFF(day, HOTPRICE.HOT_FM_DATE ,getdate()) = 0  ORDER BY HOTPRICE.HOT_FM_DATE"

        txt1.Text = sqlQryHtp

        Try

            Using conn As New SqlConnection(ConSrv(srv))
                Dim cmd As SqlCommand = New SqlCommand(sqlQryHtp, conn)
                conn.Open()
                cmd.CommandTimeout = 3500
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            Label1.Text += " hp:" + srv
        Catch ex As Exception
            txt1.Text = ex.ToString + "___" + sqlQryHtp
            Console.Write(sqlQryHtp)
        End Try


    End Sub

End Class
