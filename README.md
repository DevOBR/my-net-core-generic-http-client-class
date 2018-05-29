# GenericHttpClient
<h1>Introduction</h1>
<p>
  Here you can find a proyect class library where is a generic class to request information to a web api and return a generic object, it means that you can return a specified from a json object when you request web api information.
</p>

<h1>Implementation</h1>
<h2>Download project</h2>
<p>
  To have the library, you have to download project and import it into your solution, either using git clone http.... or downloading zip file.
</p>

<h2>Add the library</h2>
<p>
  Once you have downloaded the project you must import .dll file reference into your main project.
</p>

<h2>Mehtods</h2>

<h3>GetToken(....) : TokenResponse</h3>
<p>With this method you can request by post method a token which allows you to have access for another resource.</p>
<h4>Sample</h4>
<pre>
  var obj = new HttpService();
            var result = obj.GetToken(
                "http://my.url.com",
                "/api/osauth2/token",
                "user",
                "password")
                .GetAwaiter()
                .GetResult();
  // Response is a "TokenResponse" object predefined in GenericHttpClient, if you need to change it, just you must go to the correct project and make changes.
</pre>


<h3>Get<<YourObject>>(....) : Response </h3>
<p>With this method you can request just one response object by get method.</p>
<p>
  <small>
    There are overloads of these methods in the case you need to send the requested token before.
  </small>
</p>
<h4>Sample</h4>
<pre>
  var obj = new HttpService();
  var response = obj.Get<< YourObject >>(
      "http://my.url.com",
      "/api/",
      "controllerSample"
      1)
      .GetAwaiter()
      .GetResult();
      
  YourObject var = null;            
  
  if(response.IsSuccess)
    var = (YourObject)response.Result;
</pre>

  
