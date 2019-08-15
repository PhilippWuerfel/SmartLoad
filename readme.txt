Login as Driver:
  ID = Driver
  PW = qwertz
  
Login as Packer:
  ID = Packer
  PW = ertzu
  
To test connection to webservice:
  1. Start WebService.sln
    Path: *\SWE\Team 2\WebService\WebService
  2. Run IIS Express
  3. Find out IP Adress of local Server
    https://stackoverflow.com/questions/19121479/how-to-access-a-localhost-website-from-android-device/56247368#56247368
  4. In App type in IP of local Webserver in textfield underneath of button "WEBSERVCONNECT"
  5. Press WEBSERVCONNECT to check connection
    Toast "OK" means succesfull connection and download of test data
	Toast "FAILED_OR_EMPTY" means connection not succesfull
  6. Check Downloaded Data in LogCat

To Test Webservice correctly

Install the packages from: 
SWE\Team 2\WebService\WebService\WebService\packages

