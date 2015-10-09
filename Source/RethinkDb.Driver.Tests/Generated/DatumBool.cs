




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
    public class DatumBool : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #1
                 /* ExpectedOriginal: True */
                 var expected = true;
                 
                 /* Original: r.expr(True) */
                 var obtained = runOrCatch( r.expr(true) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #2
                 /* ExpectedOriginal: False */
                 var expected = false;
                 
                 /* Original: r.expr(False) */
                 var obtained = runOrCatch( r.expr(false) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #3
                 /* ExpectedOriginal: BOOL */
                 var expected = "BOOL";
                 
                 /* Original: r.expr(False).type_of() */
                 var obtained = runOrCatch( r.expr(false).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #4
                 /* ExpectedOriginal: true */
                 var expected = "true";
                 
                 /* Original: r.expr(True).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(true).coerceTo("string") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #5
                 /* ExpectedOriginal: True */
                 var expected = true;
                 
                 /* Original: r.expr(True).coerce_to('bool') */
                 var obtained = runOrCatch( r.expr(true).coerceTo("bool") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
