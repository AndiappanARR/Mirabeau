# Mirabeau assignments

1. Read functional requirement document(Mirabeau-FRD.docx) for functional flows.

2. Read Technical design documet(Mirabeau-TDD.docx) to understand all technolgies used in project.

3. Clone the solution or download and run in your machine.



# General

Mirabeau is POC site. This has sample air services.
Technologies used:

  ## Language and framework:

      •	Developed Using VS-2017
      •	.Net Framework 4.6
      •	.Net MVC 5
      •	C# 6.0
   ## tech used:

    •	Microsoft unity container for IOC
    •	Newtonsoft for Json serialization
    •	Bootstrap for html 
    •	Jquery for script actions


  ## Pre requisites
  VIsual studio 2015 or higher
  .Net Framework installed / .Net MVC
  
  
  ## Design Pattern Involves:

    •	MVC architectural design pattern for the whole site structure
    •	Factory pattern for Business and service layers
    •	Single ton pattern for holding the service data’s.

## Solution structure:

Solution involves five different projects.
 

    1.	Mirabeau
    2.	Mirabeau.Business
    3.	Mirabeau.Common
    4.	Mirabeau.Model
    5.	Mirabeau.Service
    6.	Mirabeau.Unity
    
    
  # Extra suggessted approaches for refreshing json service datas
    
  ### Approach: Windows scheduler
      Create windows scheduler and that will communicate service and write Json for an intervel time. Application needs to get the json file.
   #### Pros

    •	No PErformance or memory glitches in server side
    •	No client side polling

   #### Cons
  •	WIndows service need to setup 
  •	Need to write json file and from that need to get the data , instead of service.
  •	Lock maintenance

 ### Approach: Timer in server side
  A server side timer will call a respective method for every interval time. 
   #### Pros

    •	Easy implemetations
    •	No client side polling

   #### Cons
  •	IIS apppool stops , timer get affect. This will again intiate. 

 ### Approach: Client side polling or Signal-R
  Client side javascript will continuosly polling to the server for refreshing json data.
   #### Pros
   
    •	No Server side dependenicies

   #### Cons
  •	Polling will cause continuous server side trips.

