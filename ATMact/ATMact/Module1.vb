Module Module1
    Dim balance As Integer = 15000
    Sub Main()
        Dim a As Char, name As String, pin As String, num1 As Integer,
            wdraw As Integer, dep As Integer, bal1 As Integer, wdrw As Integer,
            dp As Integer, studnum As Integer, grd1 As Integer, crs As String, sys As Integer, yr As String


        Console.WriteLine("[A]ATM TRANSACTION, [B]STUDENT INFORMATION SYSTEM, [C]GRADING SYSTEM, [D]INVENTORY SYSTEM")
        ' Do
        Console.WriteLine("Pick a System: ")
        a = Console.ReadLine()

        Select Case a
 'Case A ===========================================================================


            Case "A"
                Console.WriteLine("ATM TRANSACTION")
                Console.WriteLine("")

                Do
                    Console.WriteLine("ENTER YOUR PIN")
                    pin = Console.ReadLine()
                Loop While (pin <> 1234)

                Do
                    Console.WriteLine("")

                    Console.WriteLine("[1] Check Balance")
                    Console.WriteLine("[2] Withdraw Money")
                    Console.WriteLine("[3] Deposit")

                    num1 = Console.ReadLine()
                    If (num1 = 1) Then

                        Console.WriteLine("Balance: " & balance)


                    ElseIf (num1 = 2) Then
                        Console.WriteLine("Enter Amount: ")
                        wdraw = Console.ReadLine()
                        wdrw = balance - wdraw
                        balance = wdrw


                    ElseIf (num1 = 3) Then
                        Console.WriteLine("Enter Amount: ")
                        dep = Console.ReadLine()
                        dp = balance + dep

                        balance = dp
                        Console.WriteLine("Deposit Successful. New Balance: " & balance)
                    Else

                    End If
                    Console.WriteLine("Want to do another transaction?")
                    Console.WriteLine("[1]YES ,[2]NO")

                    bal1 = Console.ReadLine()


                Loop While (bal1 = 1)


'Case B ============================================================================================


            Case "B"
                Console.WriteLine("STUDENT INFORMATION SYSTEM")
                Do
                    Console.WriteLine("Student Name:")
                    name = Console.ReadLine()
                    Console.WriteLine("Student Number:")
                    studnum = Console.ReadLine()
                    Console.WriteLine("Student Course:")
                    crs = Console.ReadLine()
                    Console.WriteLine("Year:")
                    yr = Console.ReadLine()



                    Console.WriteLine("Student: " + name)
                    Console.WriteLine("Student Number: " & studnum)
                    Console.WriteLine("Course: " & crs)
                    Console.WriteLine("Year: " & yr)


                    Console.WriteLine("Want to Enter New Student?")
                    Console.WriteLine("[1]YES ,[2]NO")

                    sys = Console.ReadLine()

                Loop While sys = 1


'Case C ============================================================================================


            Case "C"
                Console.WriteLine("GRADING SYSTEM")
                Do
                    Console.WriteLine("Student Name")
                    name = Console.ReadLine()
                    Console.WriteLine("Student Number:")
                    studnum = Console.ReadLine()

                    Console.WriteLine("Subject 1")
                    Dim subj1 As Double = Console.ReadLine()

                    Console.WriteLine("Subject 2")
                    Dim subj2 As Double = Console.ReadLine()

                    Console.WriteLine("Subject 3")
                    Dim subj3 As Double = Console.ReadLine()

                    Dim avg As Double = (subj1 + subj2 + subj3) / 3

                    Console.WriteLine("Student: " + name)
                    Console.WriteLine("Student Number: " & studnum)
                    Console.WriteLine("Average: " & avg)
                    If (avg >= 75) Then
                        Console.WriteLine(name + (" You Passed!"))
                    ElseIf (avg <= 74) Then
                        Console.WriteLine(name + " You Failed!")
                    End If

                    Console.WriteLine("Want to Enter New Student?")
                    Console.WriteLine("[1]YES ,[2]NO")

                    grd1 = Console.ReadLine()

                Loop While grd1 = 1


'Case D ============================================================================================


            Case "D"

                Console.Clear()
                Console.WriteLine("INVENTORY SYSTEM")

                Dim inventory As New Dictionary(Of String, Integer)()
                Dim choice As Integer

                Do
                    Console.WriteLine("Please select an option:")
                    Console.WriteLine("1 - Add Item")
                    Console.WriteLine("2 - Remove Item")
                    Console.WriteLine("3 - View Inventory")
                    Console.WriteLine("4 - Exit to Main Menu")

                    If Integer.TryParse(Console.ReadLine(), choice) Then
                        Select Case choice
                            Case 1
                                Console.WriteLine("Enter the item name:")
                                Dim itemName As String = Console.ReadLine()
                                Console.WriteLine("Enter the quantity:")
                                Dim itemQuantity As Integer

                                If Integer.TryParse(Console.ReadLine(), itemQuantity) Then
                                    If inventory.ContainsKey(itemName) Then
                                        inventory(itemName) += itemQuantity
                                    Else
                                        inventory(itemName) = itemQuantity
                                    End If
                                    Console.WriteLine("Item added to inventory.")
                                Else
                                    Console.WriteLine("Invalid quantity. Please enter a valid number.")
                                End If

                            Case 2
                                Console.WriteLine("Enter the item name to remove:")
                                Dim itemName As String = Console.ReadLine()
                                If inventory.ContainsKey(itemName) Then
                                    Console.WriteLine("Enter the quantity to remove:")
                                    Dim removeQuantity As Integer

                                    If Integer.TryParse(Console.ReadLine(), removeQuantity) Then
                                        If removeQuantity <= inventory(itemName) Then
                                            inventory(itemName) -= removeQuantity
                                            If inventory(itemName) = 0 Then
                                                inventory.Remove(itemName)
                                            End If
                                            Console.WriteLine("Item removed from inventory.")
                                        Else
                                            Console.WriteLine("Insufficient quantity. The requested quantity exceeds the available quantity.")
                                        End If
                                    Else
                                        Console.WriteLine("Invalid quantity. Please enter a valid number.")
                                    End If
                                Else
                                    Console.WriteLine("Item not found in inventory.")
                                End If

                            Case 3
                                Console.WriteLine("Inventory:")
                                If inventory.Count > 0 Then
                                    For Each item In inventory
                                        Console.WriteLine($"{item.Key}: {item.Value}")
                                    Next
                                Else
                                    Console.WriteLine("Inventory is empty.")
                                End If

                            Case 4
                                Console.WriteLine("Exiting the Inventory System.")
                                Exit Select

                            Case Else
                                Console.WriteLine("Invalid option. Please try again.")
                        End Select
                    Else
                        Console.WriteLine("Invalid input. Please enter a valid option (1-4).")
                    End If

                    Console.WriteLine("Press Enter to continue...")
                    Console.ReadLine()

                Loop While choice <> 4


            Case Else
                Console.WriteLine("INVALID")

        End Select


    End Sub

End Module