REST.CSharp
====================

* More documentation?  http://developer.mercurypay.com
* Questions?  integrationteam@mercurypay.com
* **Feature request?** Open an issue.
* Feel like **contributing**?  Submit a pull request.


## Overview

A Visual Studio 2013 solution demonstrating an integration to Mercury's REST API.  This example demonstrates:

* simulated card read from an encrypted reader
* Credit Sale transaction
* ReturnByRecordNo transaction using the information from the credit sale response.

>There are 3 steps to process a payment with Mercury's REST API.

##Step 1: Build Request


```
dynamic data = new
{
InvoiceNo = dt,
Memo = "Your POS Name and Version",
Purchase = "1.09",
Frequency = "OneTime",
RecordNo = "RecordNumberRequested",
RefNo = dt,
EncryptedBlock = encryptedBlock,
EncryptedFormat = "MagneSafe",
EncryptedKey = encryptedKey,
OperatorID = "Current OperatorId",
AccountSource = accountType
};
```

##Step 2: Send Data

We make use of the RestSharp client library to make the REST request below.

```
var client = new RestClient(txtEndPoint.Text);
var request = new RestRequest("Credit/Sale", Method.POST);
request.RequestFormat = DataFormat.Json;
request.AddHeader("Authorization", "Basic " + merchantIdData);
request.AddBody(data);
var response = client.Execute(request);
```

##Step 3: Parse Response

We make use of the JavaScriptSerializer in the System.Web.Script.Serialization namespace to Deserialize the response above.  In this case we are deserializing to a dictionary but we could deserialize to a specific class.

```
var serializer = new JavaScriptSerializer();
dynamic item = serializer.Deserialize<object>(response.Content);

var InvoiceNo = item["InvoiceNo"];
var Purchase = item["Purchase"];
var RecordNo = item["RecordNo"];
var RefNo = item["RefNo"];

```

###©2015 Mercury Payment Systems, LLC - all rights reserved.

Disclaimer:
This software and all specifications and documentation contained herein or provided to you hereunder (the "Software") are provided free of charge strictly on an "AS IS" basis. No representations or warranties are expressed or implied, including, but not limited to, warranties of suitability, quality, merchantability, or fitness for a particular purpose (irrespective of any course of dealing, custom or usage of trade), and all such warranties are expressly and specifically disclaimed. Mercury Payment Systems shall have no liability or responsibility to you nor any other person or entity with respect to any liability, loss, or damage, including lost profits whether foreseeable or not, or other obligation for any cause whatsoever, caused or alleged to be caused directly or indirectly by the Software. Use of the Software signifies agreement with this disclaimer notice.


