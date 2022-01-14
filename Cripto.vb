Imports System.IO
Imports System.Text

Public Class Cripto

    Dim Plan01 As Integer(,)
    Dim Plan02 As Integer(,)
    Dim Plan03 As Integer(,)
    Dim Plan04 As Integer(,)
    Dim Plan05 As Integer(,)
    Dim Plan06 As Integer(,)
    Dim Plan07 As Integer(,)
    Dim Plan08 As Integer(,)
    Dim Plan09 As Integer(,)
    Dim Plan10 As Integer(,)
    Dim Plan11 As Integer(,)
    Dim Plan12 As Integer(,)
    Dim Plan13 As Integer(,)
    Dim Plan14 As Integer(,)
    Dim Plan15 As Integer(,)
    Dim Plan16 As Integer(,)
    Dim Plan17 As Integer(,)
    Dim Plan18 As Integer(,)
    Dim Plan19 As Integer(,)
    Dim Plan20 As Integer(,)
    Dim Plan21 As Integer(,)
    Dim Plan22 As Integer(,)
    Dim Plan23 As Integer(,)
    Dim Plan24 As Integer(,)
    Dim Plan25 As Integer(,)
    Dim Plan26 As Integer(,)
    Dim Plan27 As Integer(,)
    Dim Plan28 As Integer(,)
    Dim Plan29 As Integer(,)
    Dim Plan30 As Integer(,)

    Dim VE As String(,)
    Dim AM As String(,)
    Dim VD As String(,)
    Dim AZ As String(,)
    Dim RO As String(,)
    Dim BR As String(,)

    Dim M1 As String(,)
    Dim M2 As String(,)
    Dim M3 As String(,)
    Dim M4 As String(,)

    Dim Plano As Integer(,)

    Dim Segundos As Integer
    Dim Cols As Integer
    Dim Texto As String

    Dim ObjStart As Integer

    Dim ValLado As String

    Dim TipoVe As String = ""
    Dim TipoAm As String = ""
    Dim TipoVd As String = VeBrAm = VeBrAm + "L1L1I" '01

    Dim TipoAz As String = ""
    Dim TipoRo As String = ""
    Dim TipoBr As String = ""

    Dim PosVe As Integer = 0
    Dim PosAm As Integer = 0
    Dim PosVd As Integer = 0
    Dim PosAz As Integer = 0
    Dim PosRo As Integer = 0
    Dim PosBr As Integer = 0

    Dim VeBrAm As String
    Dim VeRoBr As String
    Dim VeVdRo As String
    Dim VeAmVd As String

    Dim AmVeBr As String
    Dim AmBrAz As String
    Dim AmAzVd As String
    Dim AmVdVe As String

    Dim VdVeAm As String
    Dim VdAmAz As String
    Dim VdAzRo As String
    Dim VdRoVe As String

    Dim AzAmBr As String
    Dim AzBrRo As String
    Dim AzRoVd As String
    Dim AzVdAm As String

    Dim RoVeVd As String
    Dim RoVdAz As String
    Dim RoAzBr As String
    Dim RoBrVe As String

    Dim BrVeRo As String
    Dim BrRoAz As String
    Dim BrAzAm As String
    Dim BrAmVe As String



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ObjStart = 25

        VeBrAm = ""
        VeBrAm = VeBrAm + "00C1C1 01C1C1 02L1L1 03L1L1 04C3L1I"
        VeBrAm = VeBrAm + "05L1L1 06C1C1 07L1L1 08L1L1 09C1C1 "
        VeBrAm = VeBrAm + "10L1L1 11L3L1I12L1L1 13L1L1 14L3L1I"
        VeBrAm = VeBrAm + "15L3C1 16L1L1 17C3L1 18L1L1 19L1L1 "
        VeBrAm = VeBrAm + "20L1L1 21L1L1 22L1L1 23C3L1 24L1L1 "
        VeBrAm = VeBrAm + "25C1C1 26C1L1I27C3L1 28L3C1 29C1L1I"

        VeRoBr = ""
        VeRoBr = VeRoBr + "00L1C1I01C1C1 02C3L1 03L1L1 04C3C3 "
        VeRoBr = VeRoBr + "05L1L1 06C1C1 07L1L1 08L1L1 09C1C1 "
        VeRoBr = VeRoBr + "10L1L1 11L3L3 12L1L1 13L1L1 14L3L3 "
        VeRoBr = VeRoBr + "15L3L3 16L1L1 17L3C3I18L1L1 19L3L1I"
        VeRoBr = VeRoBr + "20L1L1 21L3L1I22L1L1 23L3C3I24L1L1 "
        VeRoBr = VeRoBr + "25L1C1I26C1C1 27C3C3 28L3L3 29C1C1 "

        VeVdRo = ""
        VeVdRo = VeVdRo + "00L1L1 01C1C1 02C3C3 03L1L1 04C3C3 "
        VeVdRo = VeVdRo + "05L1L1 06C1C1 07L1L1 08L1L1 09C1C1 "
        VeVdRo = VeVdRo + "10L1L1 11C1L3 12L1L1 13L1L1 14L1L3I"
        VeVdRo = VeVdRo + "15C1L3 16L1L1 17L1L3I18L1L1 19C1L3 "
        VeVdRo = VeVdRo + "20L1L1 21L1L3I22L1L1 23C1L3 24L1L1 "
        VeVdRo = VeVdRo + "25L1L1 26L1C1I27C3C3 28L3L3 29C1C1 "

        VeAmVd = ""
        VeAmVd = VeAmVd + "00C1L1I01C1C1 02L1C3 03L1L1 04L1C3I"
        VeAmVd = VeAmVd + "05L1L1 06C1C1 07L1L1 08L1L1 09C1C1 "
        VeAmVd = VeAmVd + "10L1L1 11L1C1I12L1L1 13L1L1 14L1L1 "
        VeAmVd = VeAmVd + "15C1C1 16L1L1 17L1L1 18L1L1 19L1C1I"
        VeAmVd = VeAmVd + "20L1L1 21L1L1 22L1L1 23L1C1I24L1L1 "
        VeAmVd = VeAmVd + "25C1L1I26L1L1 27L1C3 28C1L3 29C1L1I"

        AmVeBr = ""
        AmVeBr = AmVeBr + "00C3C1I01C3L3I02L3C1 03L3C1 04L3C3I"
        AmVeBr = AmVeBr + "05L3C1 06C3L3I07L3C1 08L3C1 09C3L3I"
        AmVeBr = AmVeBr + "10L3C1 11L3C3 12C3L3 13L3C1 14L3C3I"
        AmVeBr = AmVeBr + "15C3C3 16L3C1 17L3L1I18L3C1 19L3C1 "
        AmVeBr = AmVeBr + "20L3C1 21L3C1 22L3C1 23L3L1I24L3C1 "
        AmVeBr = AmVeBr + "25C3L3I26L3L3 27L3L1I28C3C3 29L3L3 "

        AmBrAz = ""
        AmBrAz = AmBrAz + "00C1C1 01L3C1 02C1C1 03C1L1I04C3L1 "
        AmBrAz = AmBrAz + "05C1L1I06L3L3 07C1C1 08C1C3I09L3C1I"
        AmBrAz = AmBrAz + "10C1C3I11C3L1 12L3C3 13C1L3 14C3L1 "
        AmBrAz = AmBrAz + "15C3L1 16C1L3 17L1L1 18C1C3I19C1L1I"
        AmBrAz = AmBrAz + "20C1C1 21C1L1I22C1L1I23L1L1 24C1L1I"
        AmBrAz = AmBrAz + "25L3L3 26L3C3I27L1L1 28C3C1I29L3L1I"

        AmAzVd = ""
        AmAzVd = AmAzVd + "00C1C3I01C1L1I02C1L3 03L1L3 04L1C1I"
        AmAzVd = AmAzVd + "05L1C3 06L3L1I07C1C3I08C3C3 09C1L1 "
        AmAzVd = AmAzVd + "10C3C3 11L1L1 12C3L1 13L3C3 14L1C3 "
        AmAzVd = AmAzVd + "15L1L1 16L3C3I17L1C3 18C3C3 19L1L1 "
        AmAzVd = AmAzVd + "20C1C3I21L1C3 22L1C3 23L1L1 24L1C3 "
        AmAzVd = AmAzVd + "25L3C3I26C3C3 27L1L3I28C1C1 29L1L1 "

        AmVdVe = ""
        AmVdVe = AmVdVe + "00C3C3 01L1C3 02L3L3 03L3L3I04C1L3 "
        AmVdVe = AmVdVe + "05C3L3I06L1C3 07C3L3I08C3L3I09L1C3 "
        AmVdVe = AmVdVe + "10C3L3I11L1L3 12L1C3 13C3L3I14C3L3I"
        AmVdVe = AmVdVe + "15L1C3 16C3L3I17C3L3I18C3L3I19L1L3I"
        AmVdVe = AmVdVe + "20C3L3I21C3L3I22C3L3I23L1L3I24C3L3I"
        AmVdVe = AmVdVe + "25C3C3 26C3L3I27L3L3 28C1C3I29L1L3I"

        VdAmAz = ""
        VdAmAz = VdAmAz + "00L3L3 01L3L3 02C1L3 03C1C1 04C1C1 "
        VdAmAz = VdAmAz + "05C1C1 06L3C3I07C3L3 08C1L1I09L3C1 "
        VdAmAz = VdAmAz + "10C1L1I11L1L1 12L3L1I13C1C3I14C1C1 "
        VdAmAz = VdAmAz + "15L3C1 16C1C3I17C1C1 18C1L1I19C1C1 "
        VdAmAz = VdAmAz + "20C1L3 21C1C1 22C1C1 23C1C1 24C1C1 "
        VdAmAz = VdAmAz + "25L3C3I26C1L1I27C1C1 28L3L3 29C1C1 "

        VdAzRo = ""
        VdAzRo = VdAzRo + "00L3C3I01L3L1I02L3L3 03C1C3I04C1C1 "
        VdAzRo = VdAzRo + "05C1C3I06C3L1 07L3C3I08L1C3 09C1L1 "
        VdAzRo = VdAzRo + "10L1C3 11L1L1 12L1L1 13C3C3 14C1C1 "
        VdAzRo = VdAzRo + "15C1C1 16C3C3 17C1C1 18L1C3 19C1C1 "
        VdAzRo = VdAzRo + "20L3C3I21C1C1 22C1C3I23C1C1 24C1C3I"
        VdAzRo = VdAzRo + "25C3C3 26L1L1 27C1L3 28L3C1 29C1L1I"

        VdRoVe = ""
        VdRoVe = VdRoVe + "00C3L3I01L1L3I02L3C1 03C3C1I04C1C1 "
        VdRoVe = VdRoVe + "05C3C1 06L1L3I07C3C1I08C3C1I09L1L3I"
        VdRoVe = VdRoVe + "10C3C1I11L1L1 12L1C3 13C3C1I14C1C1 "
        VdRoVe = VdRoVe + "15C1L3 16C3C1I17C1C1 18C3C1I19C1C1 "
        VdRoVe = VdRoVe + "20C3C1I21C1C1 22C3C1I23C1C1 24C3C1I"
        VdRoVe = VdRoVe + "25C3L3I26L1C1I27L3C1 28C1L3 29L1C1I"

        VdVeAm = ""
        VdVeAm = VdVeAm + "00L3L3 01L3L3 02C1C1 03C1C1 04C1C1 "
        VdVeAm = VdVeAm + "05C1C1 06L3L3 07C1C1 08C1C1 09L3L3 "
        VdVeAm = VdVeAm + "10C1C1 11L1L1 12L3L3 13C1C1 14C1C1 "
        VdVeAm = VdVeAm + "15L3L3 16C1C1 17C1C1 18C1C1 19C1C1 "
        VdVeAm = VdVeAm + "20C1C1 21C1C1 22C1C1 23C1C1 24C1C1 "
        VdVeAm = VdVeAm + "25L3L3 26C1C1 27C1C1 28L3L3 29C1C1 "

        AzAmBr = ""
        AzAmBr = AzAmBr + "00C3L3I01C3C3 02L3L3 03L3L3 04L3L1I"
        AzAmBr = AzAmBr + "05L3L3 06C3C3 07L3L3 08L3L3 09C3C3 "
        AzAmBr = AzAmBr + "10L3L3 11L3L1I12L3L3 13L3L3 14L3L1I"
        AzAmBr = AzAmBr + "15C3L1 16L3L3 17L3C1 18L3L3 19L3L3 "
        AzAmBr = AzAmBr + "20L3L3 21L3L3 22L3L3 23L3C1 24L3L3 "
        AzAmBr = AzAmBr + "25C3C3 26L3C3I27L3C1 28C3L1 29L3C3I"

        AzBrRo = ""
        AzBrRo = AzBrRo + "00L3L3 01C3C3 02L3C1 03L3L3 04L1L1 "
        AzBrRo = AzBrRo + "05L3L3 06C3C3 07L3L3 08L3L3 09C3C3 "
        AzBrRo = AzBrRo + "10L3L3 11L1L1 12L3L3 13L3L3 14L1L1 "
        AzBrRo = AzBrRo + "15L1L1 16L3L3 17C1L1I18L3L3 19L3L1I"
        AzBrRo = AzBrRo + "20L3L3 21L3L1I22L3L3 23C1L1I24L3L3 "
        AzBrRo = AzBrRo + "25C3L3I26C3C3 27C1C1 28L1L1 29C3C3 "

        AzRoVd = ""
        AzRoVd = AzRoVd + "00L3L3 01C3C3 02C1C1 03L3L3 04L1L1 "
        AzRoVd = AzRoVd + "05L3L3 06C3C3 07L3L3 08L3L3 09C3C3 "
        AzRoVd = AzRoVd + "10L3L3 11L1C1 12L3L3 13L3L3 14L1L3I"
        AzRoVd = AzRoVd + "15L1C3 16L3L3 17L1L3I18L3L3 19L1C3 "
        AzRoVd = AzRoVd + "20L3L3 21L1L3I22L3L3 23L1C3 24L3L3 "
        AzRoVd = AzRoVd + "25L3L3 26C3L3 27C1C1 28L1L1 29C3C3 "

        AzVdAm = ""
        AzVdAm = AzVdAm + "00L3C3I01C3C3 02C1L3 03L3L3 04L1C3I"
        AzVdAm = AzVdAm + "05L3L3 06C3C3 07L3L3 08L3L3 09C3C3 "
        AzVdAm = AzVdAm + "10L3L3 11C1L3I12L3L3 13L3L3 14L3L3 "
        AzVdAm = AzVdAm + "15C3C3 16L3L3 17L3L3 18L3L3 19C3L3I"
        AzVdAm = AzVdAm + "20L3L3 21L3L3 22L3L3 23C3L3 24L3L3 "
        AzVdAm = AzVdAm + "25L3C3I26L3L3 27C1L3 28L1C3 29C3L3I"

        RoVeVd = ""
        RoVeVd = RoVeVd + "00C1C1 01C1L3 02L1L1 03L1C1I04L1C1 "
        RoVeVd = RoVeVd + "05L1C1I06C1L3 07L1C1I08L1C1I09C1L3 "
        RoVeVd = RoVeVd + "10L1C1I11L1L3I12C1L3 13L1C1I14L1C1I"
        RoVeVd = RoVeVd + "15C1L3 16L1C1I17L1C1I18L1L3I19L1C1I"
        RoVeVd = RoVeVd + "20L1C1I21L1C1I22L1C1I23L1L3I24L1C1I"
        RoVeVd = RoVeVd + "25C1C1 26L1C1I27L1L1 28C1C3I29L1L3I"

        RoVdAz = ""
        RoVdAz = RoVdAz + "00C1C3I01L3C3I02L1C3 03C1L3 04C1L3I"
        RoVdAz = RoVdAz + "05C1L3 06L3L1I07C1C3I08C1C1 09L3L3 "
        RoVdAz = RoVdAz + "10C1C1 11L3L3 12L3C1 13C1L1I14C1L3 "
        RoVdAz = RoVdAz + "15L3L3 16C1L1I17C1L3 18C1C1 19L3L3 "
        RoVdAz = RoVdAz + "20C1C3I21C1L3 22C1L3 23L3L3 24C1L3 "
        RoVdAz = RoVdAz + "25C1L1I26C1C1 27L1L3 28C3C3 29L3L3 "

        RoAzBr = ""
        RoAzBr = RoAzBr + "00C3C3 01C3L1 02C3C3 03L3C3I04L3C1 "
        RoAzBr = RoAzBr + "05L3C3I06L1L1 07C3C3 08C1L3I09L3L1I"
        RoAzBr = RoAzBr + "10C1C3I11L3C1 12C1L1I13L1C3 14L3C1 "
        RoAzBr = RoAzBr + "15L3C1 16L1C3 17L3L3 18C1C3I19L3C3I"
        RoAzBr = RoAzBr + "20C3C3 21L3C3I22L3C3I23L3L3 24L3C3I"
        RoAzBr = RoAzBr + "25L1L1 26C1L1I27L3L3 28C3C1I29L3L1I"

        RoBrVe = ""
        RoBrVe = RoBrVe + "00C3C1I01L1C1I02C3L1 03C3L1 04C1L1I"
        RoBrVe = RoBrVe + "05C3L1 06L1C1I07C3L1 08L3L1 09L1C1I"
        RoBrVe = RoBrVe + "10C3L1 11C1L1I12L1C1I13C3L1 14C1L1I"
        RoBrVe = RoBrVe + "15C1C1 16C3L1 17L3L1I18C3L1 19C3L1 "
        RoBrVe = RoBrVe + "20C3L1 21C3L1 22C3L1 23L3L1I24C3L1 "
        RoBrVe = RoBrVe + "25L1C1I26L1L1 27L3L1I28C1C1 29L1L1 "

        BrVeRo = ""
        BrVeRo = BrVeRo + "00L1C1I01L1L3I02C3L1 03C3C1I04C3C3 "
        BrVeRo = BrVeRo + "05C3L1I06L1L3I07C3C1I08C3C1I09L1L3I"
        BrVeRo = BrVeRo + "10C3C1I11L3L3 12L1L3I13C3C1I14C3C3 "
        BrVeRo = BrVeRo + "15L1C3 16C3C1I17C3C3 18C3C1I19C3C3 "
        BrVeRo = BrVeRo + "20C3C1I21C1C1 22C3C1I23C3C3 24C3C1I"
        BrVeRo = BrVeRo + "25L1C1I26C3L3I27C3L1 28L1C3 29C3L3I"

        BrRoAz = ""
        BrRoAz = BrRoAz + "00C1L1I01L3L1I02L1L1 03C3C1I04C3C3 "
        BrRoAz = BrRoAz + "05L1C3I06L3C3 07L1C3I08L1C3I09L3C3I"
        BrRoAz = BrRoAz + "10C1L3 11L3L3 12L3L3 13C1C1 14C3C3 "
        BrRoAz = BrRoAz + "15C3C3 16C1C1 17C3C3 18C1L3 19L3L3 "
        BrRoAz = BrRoAz + "20C1L1I21C1C1 22C1C3 23C3C3 24C1C3I"
        BrRoAz = BrRoAz + "25C1C1 26L3L3 27L1C3 28C3L1 29L3C3I"

        BrAzAm = ""
        BrAzAm = BrAzAm + "00L1L1 01L1L1 02L1C3 03C3C3 04C3C3 "
        BrAzAm = BrAzAm + "05C3C3 06C3L1I07L1C3I08L3C3I09C3L1 "
        BrAzAm = BrAzAm + "10L3C3I11L3L3 12L3L1I13C1C3I14C3C3 "
        BrAzAm = BrAzAm + "15C3L1 16C1C3I17C3C3 18L3C3I19C3C3 "
        BrAzAm = BrAzAm + "20L1C3 21C1C1 22C3C3 23C3C3 24C3C3 "
        BrAzAm = BrAzAm + "25C1L1I26L3C3I27C3C3 28L1L1 29C3C3 "

        BrAmVe = ""
        BrAmVe = BrAmVe + "00L1L1 01L1L1 02C3C3 03C3C3 04C3C3 "
        BrAmVe = BrAmVe + "05C3C3 06L1L1 07C3C3 08C3C3 09L1L1 "
        BrAmVe = BrAmVe + "10C3C3 11L3L3 12L1L1 13C3C3 14C3C3 "
        BrAmVe = BrAmVe + "15L1L1 16C3C3 17C3C3 18C3C3 19C3C3 "
        BrAmVe = BrAmVe + "20C3C3 21C1C1 22C3C3 23C3C3 24C3C3 "
        BrAmVe = BrAmVe + "25L1L1 26C3C3 27C3C3 28L1L1 29C3C3 "

        Dim Faces(5, 5) As Face

        For Linha = 0 To 4
            For Coluna = 0 To 4
                Faces(Linha, Coluna) = New Face
            Next
        Next

        For Coluna = 0 To 4
            For Linha = 0 To 4
                Faces(Linha, Coluna).Location = New System.Drawing.Point(Linha * 122 + 20, Coluna * 122 + 42)
            Next
        Next

        For Coluna = 0 To 4
            For Linha = 0 To 4
                Me.Controls.Add(Faces(Linha, Coluna))
            Next
        Next

        Hide_Faces()

        Planos()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hoje As String
        Hoje = Now()
        TextBox1.Text = Mid(Hoje, 1, 2)
        TextBox2.Text = Mid(Hoje, 4, 2)
        TextBox3.Text = Mid(Hoje, 9, 2)
        TextBox4.Text = Mid(Hoje, 12, 2)
        TextBox5.Text = Mid(Hoje, 15, 2)
        TextBox6.Text = Mid(Hoje, 18, 2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Hide_Faces()

        Segundos = Val(TextBox6.Text)
        If Segundos > 29 Then
            Segundos -= 30
        End If

        Select Case Segundos
            Case 0
                Render(Plan30)
                Plano = Plan30
            Case 1
                Render(Plan01)
                Plano = Plan01
            Case 2
                Render(Plan02)
                Plano = Plan02
            Case 3
                Render(Plan03)
                Plano = Plan03
            Case 4
                Render(Plan04)
                Plano = Plan04
            Case 5
                Render(Plan05)
                Plano = Plan05
            Case 6
                Render(Plan06)
                Plano = Plan06
            Case 7
                Render(Plan07)
                Plano = Plan07
            Case 8
                Render(Plan08)
                Plano = Plan08
            Case 9
                Render(Plan09)
                Plano = Plan09
            Case 10
                Render(Plan10)
                Plano = Plan10
            Case 11
                Render(Plan11)
                Plano = Plan11
            Case 12
                Render(Plan12)
                Plano = Plan12
            Case 13
                Render(Plan13)
                Plano = Plan13
            Case 14
                Render(Plan14)
                Plano = Plan14
            Case 15
                Render(Plan15)
                Plano = Plan15
            Case 16
                Render(Plan16)
                Plano = Plan16
            Case 17
                Render(Plan17)
                Plano = Plan17
            Case 18
                Render(Plan18)
                Plano = Plan18
            Case 19
                Render(Plan19)
                Plano = Plan19
            Case 20
                Render(Plan20)
                Plano = Plan20
            Case 21
                Render(Plan21)
                Plano = Plan21
            Case 22
                Render(Plan22)
                Plano = Plan22
            Case 23
                Render(Plan23)
                Plano = Plan23
            Case 24
                Render(Plan24)
                Plano = Plan24
            Case 25
                Render(Plan25)
                Plano = Plan25
            Case 26
                Render(Plan26)
                Plano = Plan26
            Case 27
                Render(Plan27)
                Plano = Plan27
            Case 28
                Render(Plan28)
                Plano = Plan28
            Case 29
                Render(Plan29)
                Plano = Plan29

        End Select

    End Sub

    Private Sub Hide_Faces()

        For Faces = ObjStart To ObjStart + 24

            Me.Controls().Item(Faces).Controls().Item(0).Visible = False
            Me.Controls().Item(Faces).Controls().Item(1).Visible = False
            Me.Controls().Item(Faces).Controls().Item(2).Visible = False
            Me.Controls().Item(Faces).Controls().Item(3).Visible = False
            Me.Controls().Item(Faces).Controls().Item(4).Visible = False
            Me.Controls().Item(Faces).Controls().Item(5).Visible = False
            Me.Controls().Item(Faces).Controls().Item(6).Visible = False
            Me.Controls().Item(Faces).Controls().Item(7).Visible = False
            Me.Controls().Item(Faces).Controls().Item(8).Visible = False

        Next

    End Sub

    Private Sub Render(ByVal RenderFace(,) As Integer)

        Dim ColorFace As Color

        For Linha = 0 To 4
            For Coluna = 0 To 4
                If Not RenderFace(Linha, Coluna) = 0 Then

                    Select Case RenderFace(Linha, Coluna)
                        Case 1
                            ColorFace = Color.Red
                        Case 2
                            ColorFace = Color.Yellow
                        Case 3
                            ColorFace = Color.Green
                        Case 4
                            ColorFace = Color.Blue
                        Case 5
                            ColorFace = Color.Purple
                        Case 6
                            ColorFace = Color.White
                    End Select

                    For Lin = 0 To 2
                        For Col = 0 To 2
                            Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(Lin * 3 + Col).Controls().Item(0).BackColor = ColorFace
                            Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(Lin * 3 + Col).Visible = True
                        Next
                    Next

                End If
            Next
        Next

    End Sub


    Private Sub Planos()

        Plan01 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 2, 4, 0},
                                 {0, 0, 3, 0, 0},
                                 {0, 0, 5, 0, 0},
                                 {0, 0, 6, 0, 0}}

        Plan02 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 0, 0, 0},
                                 {0, 2, 6, 0, 0},
                                 {0, 0, 4, 5, 0},
                                 {0, 0, 0, 3, 0}}

        Plan03 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 0, 0, 0},
                                 {0, 2, 6, 5, 3},
                                 {0, 4, 0, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan04 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 0, 2, 0, 0},
                                 {0, 0, 4, 0, 0},
                                 {0, 3, 5, 6, 0}}

        Plan05 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 1},
                                 {0, 6, 5, 3, 2},
                                 {0, 0, 0, 0, 4},
                                 {0, 0, 0, 0, 0}}

        Plan06 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 2, 0, 0},
                                 {0, 0, 3, 0, 0},
                                 {0, 0, 5, 0, 0},
                                 {0, 0, 6, 4, 0}}

        Plan07 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 1},
                                 {0, 6, 5, 3, 2},
                                 {0, 4, 0, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan08 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 6, 5},
                                 {0, 4, 0, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan09 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 2, 0, 0},
                                 {0, 0, 3, 4, 0},
                                 {0, 0, 5, 0, 0},
                                 {0, 0, 6, 0, 0}}

        Plan10 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 1},
                                 {0, 6, 5, 3, 2},
                                 {0, 0, 0, 4, 0},
                                 {0, 0, 0, 0, 0}}

        Plan11 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 0, 2, 0, 0},
                                 {0, 3, 4, 0, 0},
                                 {0, 0, 5, 6, 0}}

        Plan12 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 2, 0, 0},
                                 {0, 0, 3, 0, 0},
                                 {0, 0, 5, 4, 0},
                                 {0, 0, 6, 0, 0}}

        Plan13 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 1, 0},
                                 {0, 5, 3, 2, 6},
                                 {0, 4, 0, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan14 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 0, 0},
                                 {0, 0, 4, 0, 0},
                                 {0, 0, 5, 6, 0}}

        Plan15 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 1, 2, 0, 0},
                                 {0, 0, 3, 4, 0},
                                 {0, 0, 0, 5, 6},
                                 {0, 0, 0, 0, 0}}

        Plan16 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 1},
                                 {0, 6, 5, 3, 2},
                                 {0, 0, 4, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan17 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 0, 0},
                                 {0, 0, 4, 6, 0},
                                 {0, 0, 5, 0, 0}}

        Plan18 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 1, 0},
                                 {0, 5, 3, 2, 6},
                                 {0, 0, 4, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan19 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 0, 2, 6, 0},
                                 {0, 3, 4, 0, 0},
                                 {0, 0, 5, 0, 0}}

        Plan20 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 6, 5},
                                 {0, 0, 0, 4, 0},
                                 {0, 0, 0, 0, 0}}

        Plan21 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 6, 0},
                                 {0, 0, 4, 0, 0},
                                 {0, 0, 5, 0, 0}}

        Plan22 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 3, 2, 6, 5},
                                 {0, 0, 4, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan23 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 1, 0, 0},
                                 {0, 0, 2, 0, 0},
                                 {0, 3, 4, 6, 0},
                                 {0, 0, 5, 0, 0}}

        Plan24 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 1, 0},
                                 {0, 5, 3, 2, 6},
                                 {0, 0, 0, 4, 0},
                                 {0, 0, 0, 0, 0}}

        Plan25 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 1, 2},
                                 {0, 0, 5, 3, 0},
                                 {0, 6, 4, 0, 0},
                                 {0, 0, 0, 0, 0}}

        Plan26 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 1, 0},
                                 {0, 0, 3, 2, 0},
                                 {0, 5, 4, 0, 0},
                                 {0, 6, 0, 0, 0}}

        Plan27 = New Integer(,) {{0, 0, 1, 0, 0},
                                 {0, 0, 2, 0, 0},
                                 {0, 0, 4, 6, 0},
                                 {0, 0, 0, 5, 0},
                                 {0, 0, 0, 3, 0}}

        Plan28 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 0},
                                 {1, 2, 4, 0, 0},
                                 {0, 0, 3, 5, 6},
                                 {0, 0, 0, 0, 0}}

        Plan29 = New Integer(,) {{0, 0, 0, 1, 0},
                                 {0, 0, 0, 2, 0},
                                 {0, 0, 3, 4, 0},
                                 {0, 0, 5, 0, 0},
                                 {0, 0, 6, 0, 0}}

        Plan30 = New Integer(,) {{0, 0, 0, 0, 0},
                                 {0, 0, 0, 0, 0},
                                 {0, 0, 1, 2, 4},
                                 {6, 5, 3, 0, 0},
                                 {0, 0, 0, 0, 0}}


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Inicia()

        Texto = TextBox7.Text

        Alocacao()


    End Sub

    Private Sub Inicia()

        VE = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        AM = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        VD = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        AZ = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        RO = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        BR = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        M1 = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        M2 = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        M3 = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

        M4 = New String(,) {{"", "", ""},
                            {"", "", ""},
                            {"", "", ""}}

    End Sub

    Private Sub SetSide1(ByVal Lado1 As String(,), ByVal Textos As String)

        For linhas = 0 To 2
            For Colunas = 0 To 2
                Lado1(Colunas, linhas) = Mid(Textos, 1, 1)
                Textos = Mid(Textos, 2)
            Next
        Next

    End Sub

    Private Sub SetSide2(ByVal Lado1 As String(,), ByVal Lado2 As String(,), ByVal Textos As String)

        For linhas = 0 To 2
            For Colunas = 0 To 5
                If Colunas < 3 Then
                    Lado1(Colunas, linhas) = Mid(Textos, 1, 1)
                Else
                    Lado2(Colunas - 3, linhas) = Mid(Textos, 1, 1)
                End If
                Textos = Mid(Textos, 2)
            Next
        Next

    End Sub


    Private Sub SetSide3(ByVal Lado1 As String(,), ByVal Lado2 As String(,), ByVal Lado3 As String(,), ByVal Textos As String)

        For linhas = 0 To 2
            For Colunas = 0 To 8
                If Colunas < 3 Then
                    Lado1(Colunas, linhas) = Mid(Textos, 1, 1)
                Else
                    If Colunas < 6 Then
                        Lado2(Colunas - 3, linhas) = Mid(Textos, 1, 1)
                    Else
                        Lado3(Colunas - 6, linhas) = Mid(Textos, 1, 1)
                    End If
                End If
                Textos = Mid(Textos, 2)
            Next
        Next

    End Sub

    Private Sub SetSide4(ByVal Lado1 As String(,), ByVal Lado2 As String(,), ByVal Lado3 As String(,), ByVal Lado4 As String(,), ByVal Textos As String)

        For linhas = 0 To 2
            For Colunas = 0 To 11
                If Colunas < 3 Then
                    Lado1(Colunas, linhas) = Mid(Textos, 1, 1)
                Else
                    If Colunas < 6 Then
                        Lado2(Colunas - 3, linhas) = Mid(Textos, 1, 1)
                    Else
                        If Colunas < 9 Then
                            Lado3(Colunas - 6, linhas) = Mid(Textos, 1, 1)
                        Else
                            Lado4(Colunas - 9, linhas) = Mid(Textos, 1, 1)
                        End If
                    End If
                End If
                Textos = Mid(Textos, 2)
            Next
        Next

    End Sub

    Private Sub TurnFaces()

        Dim NumMax As Integer

        If TextBox1.Text > TextBox2.Text Then
            NumMax = TextBox1.Text
        Else
            NumMax = TextBox2.Text
        End If

        If TextBox3.Text > NumMax Then
            NumMax = TextBox3.Text
        End If

        If TextBox4.Text > NumMax Then
            NumMax = TextBox4.Text
        End If

        If TextBox5.Text > NumMax Then
            NumMax = TextBox5.Text
        End If

        If TextBox6.Text > NumMax Then
            NumMax = TextBox6.Text
        End If

        Dim TpSide(3) As String
        Dim VeSide(3) As String
        Dim AmSide(3) As String
        Dim VdSide(3) As String
        Dim AzSide(3) As String
        Dim RoSide(3) As String
        Dim BrSide(3) As String

        For Turns = 1 To NumMax + 1

            If Turns <= TextBox1.Text + 1 Then

                SetTipo("VE")
                SetPos("VE")

                TurnFaces(VE)

                TpSide = GetSide(AM, TipoAm, PosAm)
                AmSide = GetSide(AM, TipoAm, PosAm)
                VdSide = GetSide(VD, TipoVd, PosVd)
                RoSide = GetSide(RO, TipoRo, PosRo)
                BrSide = GetSide(BR, TipoBr, PosBr)

                TurnSides(BrSide, AmSide, VeBrAm.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, BrSide, VeRoBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(VdSide, RoSide, VeVdRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, VdSide, VeAmVd.Substring(Segundos * 7 + 6, 1))

                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(RO, RoSide, TipoRo, PosRo)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

            If Turns <= TextBox2.Text + 1 Then

                SetTipo("AM")
                SetPos("AM")

                TurnFaces(AM)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                BrSide = GetSide(BR, TipoBr, PosBr)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                VdSide = GetSide(VD, TipoVd, PosVd)

                TurnSides(VdSide, VeSide, AmVdVe.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, VdSide, AmAzVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(BrSide, AzSide, AmBrAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, BrSide, AmVeBr.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

            If Turns <= TextBox3.Text + 1 Then

                SetTipo("VD")
                SetPos("VD")

                TurnFaces(VD)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                AmSide = GetSide(AM, TipoAm, PosAm)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                RoSide = GetSide(RO, TipoRo, PosRo)

                TurnSides(RoSide, VeSide, VdRoVe.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, RoSide, VdAzRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(AmSide, AzSide, VdAmAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, AmSide, VdVeAm.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(RO, RoSide, TipoRo, PosRo)

                Atualiza()

            End If

            If Turns <= TextBox4.Text + 1 Then

                SetTipo("AZ")
                SetPos("AZ")

                TurnFaces(AZ)

                TpSide = GetSide(AM, TipoAm, PosAm)
                AmSide = GetSide(AM, TipoAm, PosAm)
                BrSide = GetSide(BR, TipoBr, PosBr)
                RoSide = GetSide(RO, TipoRo, PosRo)
                VdSide = GetSide(VD, TipoVd, PosVd)

                TurnSides(VdSide, AmSide, AzVdAm.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, VdSide, AzRoVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(BrSide, RoSide, AzBrRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, BrSide, AzAmBr.Substring(Segundos * 7 + 6, 1))

                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(BR, BrSide, TipoBr, PosBr)
                SetSide(RO, RoSide, TipoRo, PosRo)
                SetSide(VD, VdSide, TipoVd, PosVd)

                Atualiza()

            End If

            If Turns <= TextBox5.Text + 1 Then

                SetTipo("RO")
                SetPos("RO")

                TurnFaces(RO)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                VdSide = GetSide(VD, TipoVd, PosVd)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                BrSide = GetSide(BR, TipoBr, PosBr)

                TurnSides(BrSide, VeSide, RoBrVe.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, BrSide, RoAzBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(VdSide, AzSide, RoVdAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, VdSide, RoVeVd.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

            If Turns <= TextBox6.Text + 1 Then

                SetTipo("BR")
                SetPos("BR")

                TurnFaces(BR)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                RoSide = GetSide(RO, TipoRo, PosRo)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                AmSide = GetSide(AM, TipoAm, PosAm)

                TurnSides(AmSide, VeSide, BrAmVe.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, AmSide, BrAzAm.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, AzSide, BrRoAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, RoSide, BrVeRo.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(RO, RoSide, TipoRo, PosRo)

                Atualiza()

            End If

        Next

    End Sub

    Private Sub TurnFaces(ByRef Face As String(,))

        ValLado = Face(0, 0)

        Face(0, 0) = Face(0, 2)
        Face(0, 2) = Face(2, 2)
        Face(2, 2) = Face(2, 0)
        Face(2, 0) = ValLado

        ValLado = Face(1, 0)

        Face(1, 0) = Face(0, 1)
        Face(0, 1) = Face(1, 2)
        Face(1, 2) = Face(2, 1)
        Face(2, 1) = ValLado

    End Sub

    Private Function GetSide(ByVal Sides As String(,), ByVal Tipo As String, ByVal Pos As Integer)

        Dim Side(3) As String

        If Tipo = "L" Then
            Side(0) = Sides(0, Pos)
            Side(1) = Sides(1, Pos)
            Side(2) = Sides(2, Pos)
        Else
            Side(0) = Sides(Pos, 0)
            Side(1) = Sides(Pos, 1)
            Side(2) = Sides(Pos, 2)
        End If

        GetSide = Side

    End Function

    Private Sub SetSide(ByRef Sides As String(,), ByVal Side As String(), ByVal Tipo As String, ByVal Pos As Integer)

        If Tipo = "L" Then
            Sides(0, Pos) = Side(0)
            Sides(1, Pos) = Side(1)
            Sides(2, Pos) = Side(2)
        Else
            Sides(Pos, 0) = Side(0)
            Sides(Pos, 1) = Side(1)
            Sides(Pos, 2) = Side(2)
        End If

    End Sub

    Private Sub TurnSides(ByVal Origem As String(), ByRef Destino As String(), ByVal Tipo As String)

        Destino(1) = Origem(1)

        If Tipo = "I" Then
            Destino(0) = Origem(2)
            Destino(2) = Origem(0)
        Else
            Destino(0) = Origem(0)
            Destino(2) = Origem(2)
        End If

    End Sub

    Private Sub SetTipo(ByVal ColorSet)

        If ColorSet = "VE" Then
            TipoAm = VeAmVd.Substring(Segundos * 7 + 2, 1)
            TipoVd = VeVdRo.Substring(Segundos * 7 + 2, 1)
            TipoRo = VeRoBr.Substring(Segundos * 7 + 2, 1)
            TipoBr = VeBrAm.Substring(Segundos * 7 + 2, 1)
        End If

        If ColorSet = "AM" Then
            TipoVe = AmVeBr.Substring(Segundos * 7 + 2, 1)
            TipoBr = AmBrAz.Substring(Segundos * 7 + 2, 1)
            TipoAz = AmAzVd.Substring(Segundos * 7 + 2, 1)
            TipoVd = AmVdVe.Substring(Segundos * 7 + 2, 1)
        End If

        If ColorSet = "VD" Then
            TipoVe = VdVeAm.Substring(Segundos * 7 + 2, 1)
            TipoAm = VdAmAz.Substring(Segundos * 7 + 2, 1)
            TipoAz = VdAzRo.Substring(Segundos * 7 + 2, 1)
            TipoRo = VdRoVe.Substring(Segundos * 7 + 2, 1)
        End If

        If ColorSet = "AZ" Then
            TipoAm = AzAmBr.Substring(Segundos * 7 + 2, 1)
            TipoBr = AzBrRo.Substring(Segundos * 7 + 2, 1)
            TipoRo = AzRoVd.Substring(Segundos * 7 + 2, 1)
            TipoVd = AzVdAm.Substring(Segundos * 7 + 2, 1)
        End If

        If ColorSet = "RO" Then
            TipoVe = RoVeVd.Substring(Segundos * 7 + 2, 1)
            TipoVd = RoVdAz.Substring(Segundos * 7 + 2, 1)
            TipoAz = RoAzBr.Substring(Segundos * 7 + 2, 1)
            TipoBr = RoBrVe.Substring(Segundos * 7 + 2, 1)
        End If

        If ColorSet = "BR" Then
            TipoVe = BrVeRo.Substring(Segundos * 7 + 2, 1)
            TipoAm = BrAmVe.Substring(Segundos * 7 + 2, 1)
            TipoAz = BrAzAm.Substring(Segundos * 7 + 2, 1)
            TipoRo = BrRoAz.Substring(Segundos * 7 + 2, 1)
        End If

    End Sub

    Private Sub SetPos(ByVal ColorSet As String)

        If ColorSet = "VE" Then
            PosAm = Val(VeAmVd.Substring(Segundos * 7 + 3, 1)) - 1
            PosVd = Val(VeVdRo.Substring(Segundos * 7 + 3, 1)) - 1
            PosRo = Val(VeRoBr.Substring(Segundos * 7 + 3, 1)) - 1
            PosBr = Val(VeBrAm.Substring(Segundos * 7 + 3, 1)) - 1
        End If

        If ColorSet = "AM" Then
            PosVe = Val(AmVeBr.Substring(Segundos * 7 + 3, 1)) - 1
            PosBr = Val(AmBrAz.Substring(Segundos * 7 + 3, 1)) - 1
            PosAz = Val(AmAzVd.Substring(Segundos * 7 + 3, 1)) - 1
            PosVd = Val(AmVdVe.Substring(Segundos * 7 + 3, 1)) - 1
        End If

        If ColorSet = "VD" Then
            PosVe = Val(VdVeAm.Substring(Segundos * 7 + 3, 1)) - 1
            PosAm = Val(VdAmAz.Substring(Segundos * 7 + 3, 1)) - 1
            PosAz = Val(VdAzRo.Substring(Segundos * 7 + 3, 1)) - 1
            PosRo = Val(VdRoVe.Substring(Segundos * 7 + 3, 1)) - 1
        End If

        If ColorSet = "AZ" Then
            PosAm = Val(AzAmBr.Substring(Segundos * 7 + 3, 1)) - 1
            PosBr = Val(AzBrRo.Substring(Segundos * 7 + 3, 1)) - 1
            PosRo = Val(AzRoVd.Substring(Segundos * 7 + 3, 1)) - 1
            PosVd = Val(AzVdAm.Substring(Segundos * 7 + 3, 1)) - 1
        End If

        If ColorSet = "RO" Then
            PosVe = Val(RoVeVd.Substring(Segundos * 7 + 3, 1)) - 1
            PosVd = Val(RoVdAz.Substring(Segundos * 7 + 3, 1)) - 1
            PosAz = Val(RoAzBr.Substring(Segundos * 7 + 3, 1)) - 1
            PosBr = Val(RoBrVe.Substring(Segundos * 7 + 3, 1)) - 1
        End If

        If ColorSet = "BR" Then
            PosVe = Val(BrVeRo.Substring(Segundos * 7 + 3, 1)) - 1
            PosRo = Val(BrRoAz.Substring(Segundos * 7 + 3, 1)) - 1
            PosAz = Val(BrAzAm.Substring(Segundos * 7 + 3, 1)) - 1
            PosAm = Val(BrAmVe.Substring(Segundos * 7 + 3, 1)) - 1
        End If

    End Sub

    Private Sub Atualiza()

        For Linha = 0 To 4
            Cols = 0
            For Coluna = 0 To 4
                If Not Plano(Linha, Coluna) = 0 Then
                    Select Case Plano(Linha, Coluna)
                        Case 1
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = VE(lin, col)
                                Next
                            Next
                        Case 2
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = AM(lin, col)
                                Next
                            Next
                        Case 3
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = VD(lin, col)
                                Next
                            Next
                        Case 4
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = AZ(lin, col)
                                Next
                            Next
                        Case 5
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = RO(lin, col)
                                Next
                            Next
                        Case 6
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = BR(lin, col)
                                Next
                            Next
                    End Select

                End If
            Next
        Next

        If CheckBox1.Checked = True Then
            MessageBox.Show("Proximo")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Val(TextBox1.Text) < 1 Or Val(TextBox1.Text) > 31 Then
            MessageBox.Show("Dia Invalido !!")
            TextBox1.Focus()
            Return
        End If

        If Val(TextBox2.Text) < 1 Or Val(TextBox2.Text) > 12 Then
            MessageBox.Show("Mes Invalido !!")
            TextBox2.Focus()
            Return
        End If

        If Val(TextBox3.Text) < 1 Or Val(TextBox3.Text) > 99 Then
            MessageBox.Show("Ano Invalido !!")
            TextBox3.Focus()
            Return
        End If

        If Val(TextBox4.Text) < 0 Or Val(TextBox4.Text) > 23 Then
            MessageBox.Show("Hora Invalida !!")
            TextBox4.Focus()
            Return
        End If

        If Val(TextBox5.Text) < 0 Or Val(TextBox5.Text) > 59 Then
            MessageBox.Show("Minuto Invalido !!")
            TextBox5.Focus()
            Return
        End If

        If Val(TextBox6.Text) < 0 Or Val(TextBox6.Text) > 59 Then
            MessageBox.Show("Segundo Invalido !!")
            TextBox6.Focus()
            Return
        End If

        TextBox8.Text = ""

        If Not CheckBox2.Checked Then

            Inicia()

            Dim Textos As String

            Textos = TextBox7.Text

            Do While Not Textos.Length = 0

                If Textos.Length < 54 Then

                    Textos = Textos + "^1234567890 QWERTYUIOP ASDFGHJKL ZXCVBNM 1234567890 QWERTYUIOPASD"
                    Texto = Textos.Substring(0, 53)
                    Textos = ""

                Else

                    Texto = Textos.Substring(0, 54)
                    Textos = Textos.Substring(54)

                End If

                Alocacao()

                TurnFaces()
                ChangeLetter("C")
                SetTexto()

            Loop


        Else

            TurnFaces()
            ChangeLetter("C")
            SetTexto()

        End If

    End Sub

    Private Sub ChangeLetter(ByVal Tipo As String)

        Dim Alfabeto As String
        Dim Letra As String
        Dim Pos As Integer

        Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Alfabeto = Alfabeto & Alfabeto & Alfabeto

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = VE(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        VE(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox1.Text), 1)
                    Else
                        VE(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox1.Text), 1)
                    End If
                End If
            Next
        Next

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = AM(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        AM(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox2.Text), 1)
                    Else
                        AM(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox2.Text), 1)
                    End If
                End If
            Next
        Next

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = VD(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        VD(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox3.Text), 1)
                    Else
                        VD(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox3.Text), 1)
                    End If
                End If
            Next
        Next

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = AZ(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        AZ(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox4.Text), 1)
                    Else
                        AZ(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox4.Text), 1)
                    End If
                End If
            Next
        Next

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = RO(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        RO(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox5.Text), 1)
                    Else
                        RO(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox5.Text), 1)
                    End If
                End If
            Next
        Next

        For lin = 0 To 2
            For Col = 0 To 2
                Letra = BR(lin, Col)
                If Tipo = "D" Then
                    Pos = Alfabeto.LastIndexOf(Letra)
                Else
                    Pos = Alfabeto.IndexOf(Letra)
                End If
                If Pos >= 0 Then
                    If Tipo = "D" Then
                        BR(lin, Col) = Alfabeto.Substring(Pos - Val(TextBox6.Text), 1)
                    Else
                        BR(lin, Col) = Alfabeto.Substring(Pos + Val(TextBox6.Text), 1)
                    End If
                End If
            Next
        Next

        Atualiza()

    End Sub

    Private Sub SetTexto()

        Dim Linha1 As String
        Dim Linha2 As String
        Dim Linha3 As String

        Texto = ""

        For Linha = 0 To 4

            Cols = 0
            Linha1 = ""
            Linha2 = ""
            Linha3 = ""

            For Coluna = 0 To 4
                If Not Plano(Linha, Coluna) = 0 Then
                    GetSides(Plano(Linha, Coluna), Linha1, Linha2, Linha3)
                End If
            Next

            Texto = Texto & Linha1 & Linha2 & Linha3

        Next

        TextBox8.Text = TextBox8.Text & Texto

    End Sub

    Private Sub GetSides(ByVal Colors As Integer, ByRef L1 As String, ByRef L2 As String, ByRef L3 As String)

        Dim Lados(3, 3) As String

        If Colors = 1 Then
            Lados = VE.Clone()
        End If

        If Colors = 2 Then
            Lados = AM.Clone()
        End If

        If Colors = 3 Then
            Lados = VD.Clone()
        End If

        If Colors = 4 Then
            Lados = AZ.Clone()
        End If

        If Colors = 5 Then
            Lados = RO.Clone()
        End If

        If Colors = 6 Then
            Lados = BR.Clone()
        End If

        For Linss = 0 To 2
            For Colss = 0 To 2
                If Linss = 0 Then
                    L1 = L1 + Lados(Colss, Linss)
                End If
                If Linss = 1 Then
                    L2 = L2 + Lados(Colss, Linss)
                End If
                If Linss = 2 Then
                    L3 = L3 + Lados(Colss, Linss)
                End If
            Next
        Next

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Val(TextBox1.Text) < 1 Or Val(TextBox1.Text) > 31 Then
            MessageBox.Show("Dia Invalido !!")
            TextBox1.Focus()
            Return
        End If

        If Val(TextBox2.Text) < 1 Or Val(TextBox2.Text) > 12 Then
            MessageBox.Show("Mes Invalido !!")
            TextBox2.Focus()
            Return
        End If

        If Val(TextBox3.Text) < 1 Or Val(TextBox3.Text) > 99 Then
            MessageBox.Show("Ano Invalido !!")
            TextBox3.Focus()
            Return
        End If

        If Val(TextBox4.Text) < 0 Or Val(TextBox4.Text) > 23 Then
            MessageBox.Show("Hora Invalida !!")
            TextBox4.Focus()
            Return
        End If

        If Val(TextBox5.Text) < 0 Or Val(TextBox5.Text) > 59 Then
            MessageBox.Show("Minuto Invalido !!")
            TextBox5.Focus()
            Return
        End If

        If Val(TextBox6.Text) < 0 Or Val(TextBox6.Text) > 59 Then
            MessageBox.Show("Segundo Invalido !!")
            TextBox6.Focus()
            Return
        End If

        TextBox8.Text = ""

        If Not CheckBox2.Checked Then

            Inicia()

            Dim Textos As String

            Textos = TextBox7.Text

            Do While Not Textos.Length = 0


                Texto = Textos.Substring(0, 54)
                Textos = Textos.Substring(54)

                Alocacao()

                ChangeLetter("D")
                TurnFacesD()
                SetTexto()

            Loop

        Else

            ChangeLetter("D")
            TurnFacesD()
            SetTexto()

        End If

    End Sub

    Private Sub TurnFacesD()

        Dim NumMax As Integer

        If TextBox1.Text > TextBox2.Text Then
            NumMax = TextBox1.Text
        Else
            NumMax = TextBox2.Text
        End If

        If TextBox3.Text > NumMax Then
            NumMax = TextBox3.Text
        End If

        If TextBox4.Text > NumMax Then
            NumMax = TextBox4.Text
        End If

        If TextBox5.Text > NumMax Then
            NumMax = TextBox5.Text
        End If

        If TextBox6.Text > NumMax Then
            NumMax = TextBox6.Text
        End If

        Dim TpSide(3) As String
        Dim VeSide(3) As String
        Dim AmSide(3) As String
        Dim VdSide(3) As String
        Dim AzSide(3) As String
        Dim RoSide(3) As String
        Dim BrSide(3) As String

        For Turns = NumMax + 1 To 1 Step -1

            If Turns <= TextBox6.Text + 1 Then

                SetTipo("BR")
                SetPos("BR")

                TurnFacesr(BR)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                RoSide = GetSide(RO, TipoRo, PosRo)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                AmSide = GetSide(AM, TipoAm, PosAm)

                TurnSides(RoSide, VeSide, BrVeRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, RoSide, BrRoAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(AmSide, AzSide, BrAzAm.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, AmSide, BrAmVe.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(RO, RoSide, TipoRo, PosRo)

                Atualiza()

            End If

            If Turns <= TextBox5.Text + 1 Then

                SetTipo("RO")
                SetPos("RO")

                TurnFacesr(RO)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                VdSide = GetSide(VD, TipoVd, PosVd)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                BrSide = GetSide(BR, TipoBr, PosBr)

                TurnSides(VdSide, VeSide, RoVeVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, VdSide, RoVdAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(BrSide, AzSide, RoAzBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, BrSide, RoBrVe.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

            If Turns <= TextBox4.Text + 1 Then

                SetTipo("AZ")
                SetPos("AZ")

                TurnFacesr(AZ)

                TpSide = GetSide(AM, TipoAm, PosAm)
                AmSide = GetSide(AM, TipoAm, PosAm)
                BrSide = GetSide(BR, TipoBr, PosBr)
                RoSide = GetSide(RO, TipoRo, PosRo)
                VdSide = GetSide(VD, TipoVd, PosVd)

                TurnSides(BrSide, AmSide, AzAmBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, BrSide, AzBrRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(VdSide, RoSide, AzRoVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, VdSide, AzVdAm.Substring(Segundos * 7 + 6, 1))

                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(BR, BrSide, TipoBr, PosBr)
                SetSide(RO, RoSide, TipoRo, PosRo)
                SetSide(VD, VdSide, TipoVd, PosVd)

                Atualiza()

            End If

            If Turns <= TextBox3.Text + 1 Then

                SetTipo("VD")
                SetPos("VD")

                TurnFacesr(VD)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                AmSide = GetSide(AM, TipoAm, PosAm)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                RoSide = GetSide(RO, TipoRo, PosRo)

                TurnSides(AmSide, VeSide, VdVeAm.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, AmSide, VdAmAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, AzSide, VdAzRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, RoSide, VdRoVe.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(RO, RoSide, TipoRo, PosRo)

                Atualiza()

            End If

            If Turns <= TextBox2.Text + 1 Then

                SetTipo("AM")
                SetPos("AM")

                TurnFacesr(AM)

                TpSide = GetSide(VE, TipoVe, PosVe)
                VeSide = GetSide(VE, TipoVe, PosVe)
                BrSide = GetSide(BR, TipoBr, PosBr)
                AzSide = GetSide(AZ, TipoAz, PosAz)
                VdSide = GetSide(VD, TipoVd, PosVd)

                TurnSides(BrSide, VeSide, AmVeBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(AzSide, BrSide, AmBrAz.Substring(Segundos * 7 + 6, 1))
                TurnSides(VdSide, AzSide, AmAzVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, VdSide, AmVdVe.Substring(Segundos * 7 + 6, 1))

                SetSide(VE, VeSide, TipoVe, PosVe)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(AZ, AzSide, TipoAz, PosAz)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

            If Turns <= TextBox1.Text + 1 Then

                SetTipo("VE")
                SetPos("VE")

                TurnFacesr(VE)

                TpSide = GetSide(AM, TipoAm, PosAm)
                AmSide = GetSide(AM, TipoAm, PosAm)
                VdSide = GetSide(VD, TipoVd, PosVd)
                RoSide = GetSide(RO, TipoRo, PosRo)
                BrSide = GetSide(BR, TipoBr, PosBr)

                TurnSides(VdSide, AmSide, VeAmVd.Substring(Segundos * 7 + 6, 1))
                TurnSides(RoSide, VdSide, VeVdRo.Substring(Segundos * 7 + 6, 1))
                TurnSides(BrSide, RoSide, VeRoBr.Substring(Segundos * 7 + 6, 1))
                TurnSides(TpSide, BrSide, VeBrAm.Substring(Segundos * 7 + 6, 1))

                SetSide(AM, AmSide, TipoAm, PosAm)
                SetSide(VD, VdSide, TipoVd, PosVd)
                SetSide(RO, RoSide, TipoRo, PosRo)
                SetSide(BR, BrSide, TipoBr, PosBr)

                Atualiza()

            End If

        Next

    End Sub

    Private Sub TurnFacesr(ByRef Face As String(,))

        ValLado = Face(0, 0)

        Face(0, 0) = Face(2, 0)
        Face(2, 0) = Face(2, 2)
        Face(2, 2) = Face(0, 2)
        Face(0, 2) = ValLado

        ValLado = Face(1, 0)

        Face(1, 0) = Face(2, 1)
        Face(2, 1) = Face(1, 2)
        Face(1, 2) = Face(0, 1)
        Face(0, 1) = ValLado

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.Text = UCase(TextBox7.Text)
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox9.Text = "" Or Not File.Exists(TextBox9.Text) Then
            MessageBox.Show("Arquivo Inexistente !!!")
            Return
        End If

        Dim sFileName As String
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim separador As Integer
        Dim Chave As String
        Dim ValChave As Long
        Dim letra As String

        ValChave = 0

        sFileName = TextBox9.Text
        srFileReader = System.IO.File.OpenText(sFileName)
        sInputLine = srFileReader.ReadLine()
        Do Until sInputLine Is Nothing
            TextBox7.Text = TextBox7.Text & UCase(sInputLine)
            sInputLine = srFileReader.ReadLine()
        Loop

        sInputLine = TextBox7.Text
        separador = sInputLine.LastIndexOf("#")

        If separador <> -1 Then

            Chave = sInputLine.Substring(separador + 1)
            TextBox7.Text = sInputLine.Substring(0, separador)

            For pos = 0 To (Chave.Length - 1)

                letra = Chave.Substring((Chave.Length - pos - 1), 1)
                Select Case letra
                    Case "A"
                        ValChave = ValChave + (10 * (16 ^ pos))
                    Case "B"
                        ValChave = ValChave + (11 * (16 ^ pos))
                    Case "C"
                        ValChave = ValChave + (12 * (16 ^ pos))
                    Case "D"
                        ValChave = ValChave + (13 * (16 ^ pos))
                    Case "E"
                        ValChave = ValChave + (14 * (16 ^ pos))
                    Case "F"
                        ValChave = ValChave + (15 * (16 ^ pos))
                    Case Is > 0
                        ValChave = ValChave + (Val(letra) * (16 ^ pos))
                End Select

            Next

            Chave = Format(ValChave, "000000000000")
            TextBox1.Text = Chave.Substring(0, 2)
            TextBox2.Text = Chave.Substring(2, 2)
            TextBox3.Text = Chave.Substring(4, 2)
            TextBox4.Text = Chave.Substring(6, 2)
            TextBox5.Text = Chave.Substring(8, 2)
            TextBox6.Text = Chave.Substring(10, 2)

        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If TextBox10.Text = "" Then
            MessageBox.Show("Arquivo Inexistente !!!")
            Return
        End If

        Dim path As String = TextBox10.Text
        Dim Chave As String
        Dim ValChave As Long
        Dim Resto As Integer

        ValChave = Val(Format(Val(TextBox1.Text), "00") &
                       Format(Val(TextBox2.Text), "00") &
                       Format(Val(TextBox3.Text), "00") &
                       Format(Val(TextBox4.Text), "00") &
                       Format(Val(TextBox5.Text), "00") &
                       Format(Val(TextBox6.Text), "00"))
        Chave = ""
        Do While ValChave > 0

            Resto = ValChave Mod 16

            Select Case Resto
                Case Is < 10
                    Chave = Trim(Str(Resto)) & Chave
                Case 10
                    Chave = "A" & Chave
                Case 11
                    Chave = "B" & Chave
                Case 12
                    Chave = "C" & Chave
                Case 13
                    Chave = "D" & Chave
                Case 14
                    Chave = "E" & Chave
                Case 15
                    Chave = "F" & Chave
            End Select

            ValChave = Int(ValChave / 16)

        Loop

        Dim appendText As String = TextBox8.Text & "#" & Chave + Environment.NewLine
        File.AppendAllText(path, appendText, Encoding.UTF8)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Alocacao()

        For Linha = 0 To 4
            Cols = 0
            For Coluna = 0 To 4
                If Not Plano(Linha, Coluna) = 0 Then
                    Cols += 1
                End If
            Next
            Select Case Cols
                Case 1
                    SetSide1(M1, Mid(Texto, 1, 9))
                    Texto = Mid(Texto, 10)
                Case 2
                    SetSide2(M1, M2, Mid(Texto, 1, 18))
                    Texto = Mid(Texto, 19)
                Case 3
                    SetSide3(M1, M2, M3, Mid(Texto, 1, 27))
                    Texto = Mid(Texto, 28)
                Case 4
                    SetSide4(M1, M2, M3, M4, Mid(Texto, 1, 36))
                    Texto = Mid(Texto, 37)
            End Select
            Cols = 0
            For Coluna = 0 To 4
                If Not Plano(Linha, Coluna) = 0 Then
                    Cols += 1
                    Select Case Plano(Linha, Coluna)
                        Case 1
                            Select Case Cols
                                Case 1
                                    VE = M1.Clone()
                                Case 2
                                    VE = M2.Clone()
                                Case 3
                                    VE = M3.Clone()
                                Case 4
                                    VE = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = VE(lin, col)
                                Next
                            Next
                        Case 2
                            Select Case Cols
                                Case 1
                                    AM = M1.Clone()
                                Case 2
                                    AM = M2.Clone()
                                Case 3
                                    AM = M3.Clone()
                                Case 4
                                    AM = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = AM(lin, col)
                                Next
                            Next
                        Case 3
                            Select Case Cols
                                Case 1
                                    VD = M1.Clone()
                                Case 2
                                    VD = M2.Clone()
                                Case 3
                                    VD = M3.Clone()
                                Case 4
                                    VD = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = VD(lin, col)
                                Next
                            Next
                        Case 4
                            Select Case Cols
                                Case 1
                                    AZ = M1.Clone()
                                Case 2
                                    AZ = M2.Clone()
                                Case 3
                                    AZ = M3.Clone()
                                Case 4
                                    AZ = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = AZ(lin, col)
                                Next
                            Next
                        Case 5
                            Select Case Cols
                                Case 1
                                    RO = M1.Clone()
                                Case 2
                                    RO = M2.Clone()
                                Case 3
                                    RO = M3.Clone()
                                Case 4
                                    RO = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = RO(lin, col)
                                Next
                            Next
                        Case 6
                            Select Case Cols
                                Case 1
                                    BR = M1.Clone()
                                Case 2
                                    BR = M2.Clone()
                                Case 3
                                    BR = M3.Clone()
                                Case 4
                                    BR = M4.Clone()
                            End Select
                            For lin = 0 To 2
                                For col = 0 To 2
                                    Me.Controls().Item(Linha * 5 + Coluna + ObjStart).Controls().Item(lin * 3 + col).Controls().Item(0).Text = BR(lin, col)
                                Next
                            Next
                    End Select

                End If
            Next
        Next

    End Sub

End Class
