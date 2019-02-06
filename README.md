### Numbers to sentence converter

##### Short description
Service lets user to input a number and returns him the number represented in words.

##### Table of contents
1. [Overview](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#1-overview)
2. [Acceptance criteria](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#2-acceptance-criteria)
3. [Requirements](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#3requirements)
4. [Architecture](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#4-architecture)
5. [Service](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#5-service)
   - [Overview](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#51-overview)
   - [Third party products](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#52-third-party-products)
   - [Endpoints](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#53-endpoints)
   - [Test runs](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#54-test-runs)
   - [Run service](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#55-run-service)
   - [Request example](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#56-request-example)
6. [Client](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#6-client)
   - [Overview](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#61-overview)
   - [Install and run application](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#62-install-and-run-application)
7. [VueJS vs Angular](https://github.com/adrnilie/NumbersToWordsConverter/blob/master/README.md#7-vuejs-vs-angular)

##### 1. Overview
Application consists of two components. First is represented by the service, which is a .NET Framework (4.7.2) Web API 2 written in C#, and the second one represents the client application, which interacts with the service by making requests to the API and consuming the response from API.<br/>
Long story short, the algorithm is a multitude of switches, string appends and recursive calls.

##### 2. Acceptance criteria
**As** a user <br/>
**I want** to submit a number <br/>
**So that** I get the number represented in a sentence

##### 3.Requirements
- The code should build
- Include appropriate automated tests
- The API should be able to convert numbers from 0 to 1,000,000
- The API should be relatively RESTful, and return a JSON response
- The UI does not need to be particularly fancy, but please make it neat and tidy with some demonstration of your abilities with CSS
- Please build the UI using Angular – the version is up to you
- Use whatever .NET or JavaScript libraries you like

##### 4. Architecture
- Solution : NumbersToWordsConverter
  - NumbersToWordsConverter.Services
  - NumbersToWordConverter.Core
  - NumbersToWordsConverter.Tests
  - NumbersToWordConverter.Client
    - client-app
    
##### 5. Service
###### 5.1. Overview
- Type: **ASP.NET Web API 2**
- Frameword: **.NET Framework 4.7.2**
- Language: **C# 7**
- Design priciples: **Single responsibility**, **Encapsulation**
- Design pattern: **Repository pattern**, **Dependency injection**

###### 5.2. Third party products
- **Autofac** for dependency resolver
- **NUnit Frameword** for unit testing

###### 5.3. Endpoints
| Endpoint | Action | Description | Constraints |
|----------|--------|-------------|-------------|
|/api/convert/{number}|GET|Returns the number in sentence format|number : Integer|

###### 5.4. Test runs
![Test runs](https://i.imgur.com/uaCNxtt.png)

###### 5.5. Run service
Clone repository from github repository by using `git clone git@github.com:adrnilie/NumbersToWordsConverter.git` command.<br/>
Open the solution in Visual Studio and `NumbersToWordsConverter.Services` should be set as Startup project.<br/>
Run the solution by pressing `F5` to run with debugger attached, or `CTRL + F5` without debugger.

###### 5.6. Request example
Use your favourite browser to access the service.<br/>
An example is provided in the image below.<br/>
![Request example](https://i.imgur.com/X4Ew1rZ.png)

##### 6. Client
###### 6.1. Overview
- Framework: **Angular 7**
- Packages: **NPM**, **Angular CLI 6**
- Language: **TypeScript**

###### 6.2. Install and run application
To install and run the application, you need to have `npm (node package manager)` installed on your machine. If you already have it, you can skip the next step.<br/>

- **Install node package manager (npm)** <br/>
To install `npm` you have to access the [Node website](https://nodejs.org/en/) and download the appropiate version for your environment.<br/>
After the installation, open a `cmd` window and type `npm`. If there's no error, you can proceed.<br/>

- **Install needed packages for client application** <br/>
Open a `cmd` window and navigate to the `NumbersToWordsConverter.Client\client-app\` folder. <br/>
Run `npm install` and wait 'til the process finishes.<br/>
If everything installed successfully, you can run the app by typing `ng serve`. When the build is over, the app should be available at `http://localhost:4200/`.

##### 7. VueJS vs Angular
![Vue vs Angular](https://i.imgur.com/63jsaJJ.png)
