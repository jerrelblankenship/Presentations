// JavaScript source code
test("hello test", function(){
    ok( 1== "1","Passed");
});

test("a basic test", function () {
    var value = "hello";
    equal(value, "hello", "Expected: hello");
});

var mathLib = {
    add5: function(a) {
        return a + 5;
    }
};

test("add 5", function () {
    var res = mathLib.add5(10);
    equal(res, 15, "should be 15");
});

//module("metro");
//asyncTest("test file update", function () {
//    Windows.Storage.KnownFolders.documentsLibrary.createFileAsync("sample.txt",
//        Windows.Storage.CreationCollisionOption.replaceExisting);

//        Windows.Storage.KnownFolders.documentsLibrary.getFileAsync("sample.txt").then(
//        function (sampleFile) {
//            assert.notEqual(sampleFile, null);
//            start();
//        }
//        );
//});

module("metro");
asyncTest("test syndication", function () {
    var client = new Windows.Web.Syndication.SyndicationClient(); 
    client.bypassCacheOnRetrieve = true; 
 
    var uri = new Windows.Foundation.Uri("http://blogs.msdn.com/b/mathew_aniyan/rss.aspx");
    // Although most HTTP servers do not require User-Agent header, others will reject the request or return 
    // a different response if this header is missing. Use setRequestHeader() to add custom headers. 
    client.setRequestHeader("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)"); 
 
    client.retrieveFeedAsync(uri).done(function (feed) { 
        assert.equal(feed.title.text, "Mathew Aniyan's Blog");
        start();
    }
    );
    
    
});



