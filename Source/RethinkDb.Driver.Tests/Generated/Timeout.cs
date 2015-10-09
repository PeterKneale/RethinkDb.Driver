




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class Timeout : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #1
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 5.000 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 5.000 seconds.", r.array(0));
                 
                 /* Original: r.js('while(true) {}') */
                 var obtained = runOrCatch( r.js("while(true) {}") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #2
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 1.300 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 1.300 seconds.", r.array(0));
                 
                 /* Original: r.js('while(true) {}', timeout=1.3) */
                 var obtained = runOrCatch( r.js("while(true) {}").optArg("timeout", 1.3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #3
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 8.000 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `while(true) {}` timed out after 8.000 seconds.", r.array(0));
                 
                 /* Original: r.js('while(true) {}', timeout=8) */
                 var obtained = runOrCatch( r.js("while(true) {}").optArg("timeout", 8) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #4
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 5.000 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 5.000 seconds.", r.array(0));
                 
                 /* Original: r.expr('foo').do(r.js('(function(x) { while(true) {} })')) */
                 var obtained = runOrCatch( r.expr("foo").do_(r.js("(function(x) { while(true) {} })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #5
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 1.300 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 1.300 seconds.", r.array(0));
                 
                 /* Original: r.expr('foo').do(r.js('(function(x) { while(true) {} })', timeout=1.3)) */
                 var obtained = runOrCatch( r.expr("foo").do_(r.js("(function(x) { while(true) {} })").optArg("timeout", 1.3)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #6
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 8.000 seconds.", [0]) */
                 var expected = err("ReqlQueryLogicError", "JavaScript query `(function(x) { while(true) {} })` timed out after 8.000 seconds.", r.array(0));
                 
                 /* Original: r.expr('foo').do(r.js('(function(x) { while(true) {} })', timeout=8)) */
                 var obtained = runOrCatch( r.expr("foo").do_(r.js("(function(x) { while(true) {} })").optArg("timeout", 8)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #7
                 /* ExpectedOriginal: err("ReqlNonExistenceError", "Error in HTTP GET of `httpbin.org/delay/10`:" + " timed out after 0.800 seconds.", []) */
                 var expected = err("ReqlNonExistenceError", "Error in HTTP GET of `httpbin.org/delay/10`:" + " timed out after 0.800 seconds.", r.array());
                 
                 /* Original: r.http('httpbin.org/delay/10', timeout=0.8) */
                 var obtained = runOrCatch( r.http("httpbin.org/delay/10").optArg("timeout", 0.8) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, timeout.yaml, #8
                 /* ExpectedOriginal: err("ReqlNonExistenceError", "Error in HTTP PUT of `httpbin.org/delay/10`:" + " timed out after 0.000 seconds.", []) */
                 var expected = err("ReqlNonExistenceError", "Error in HTTP PUT of `httpbin.org/delay/10`:" + " timed out after 0.000 seconds.", r.array());
                 
                 /* Original: r.http('httpbin.org/delay/10', method='PUT', timeout=0.0) */
                 var obtained = runOrCatch( r.http("httpbin.org/delay/10").optArg("method", "PUT").optArg("timeout", 0.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
