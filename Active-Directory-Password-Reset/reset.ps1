$Pass = ConvertTo-SecureString "Password@123" -AsPlainText -Force
Set-ADAccountPassword -Identity txtUsername -NewPassword $Pass -Reset -PassThru | Set-ADUser -ChangePasswordAtLogon $true