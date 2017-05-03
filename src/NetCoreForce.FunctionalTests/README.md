
Running the functional tests will require API credentials.  
* Make a copy of the **credentials_example.json** file and rename it to **credentials_dev.json**  
* Update **credentials_dev.json** with the API credentials to your test instance.

These tests will only modify or delete objects they have created as part of the test.  
The tests should clean up after themselves, but a failed test may leave objects in the system.