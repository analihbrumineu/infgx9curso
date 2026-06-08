using System;
using GeneXus.Metadata;
using GeneXus.Data.NTier;
using GeneXus.Application;
using System.Reflection;
using GeneXus.Windows;
using com.genexus;
using System.IO;
using GeneXus.Utils;
public class call_wcontroledelocadora
{
   [STAThread]
   static public void Main( string[] args )
   {
      Object[] margs= {};
      string assm ;
      assm = "gxobjects" ;
      java.lang.Class baseWin = java.lang.Class.FromType(Assembly.Load(assm).GetType("GeneXus.Programs.ucontroledelocadora"));
      com.genexus.Application.init(baseWin);
      ModelContext ctx ;
      ctx = new ModelContext( baseWin) ;
      Object jWin = ClassLoader.GetInstance2(assm,"GeneXus.Programs.ucontroledelocadora", new Object[]{-1,ctx});
      com.genexus.Application.realMainProgram = jWin;
      ClassLoader.ExecuteRef(jWin, "execute", margs);
   }

}

