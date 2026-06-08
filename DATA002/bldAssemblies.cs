using System;
using GeneXus.Builder;
using System.IO;
public class bldAssemblies : GxBaseBuilder
{
   string cs_path = "." ;
   public bldAssemblies( ) : base()
   {
   }

   public override void BeforeCompile( )
   {
   }

   public override void AfterCompile( )
   {
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      File.Create( @"bin\bldAssemblies.txt");
   }

   static public void Main( string[] args )
   {
      bldAssemblies x = new bldAssemblies() ;
      x.SetMainSourceFile( "");
      x.LoadVariables( args);
      x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\gxCommon.dll", cs_path + @"\gxCommon.rsp");
      sc.Add( @"bin\gxobjects.dll", cs_path + @"\gxobjects.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.por.dll", cs_path + @"\messages.por.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( ( obj == @"bin\gxCommon.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\gxCommon.rsp" ))
            return true;
      }
      if ( ( obj == @"bin\gxobjects.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\gxobjects.rsp" ))
            return true;
      }
      if ( ( obj == @"bin\messages.por.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\messages.por.txt" ))
            return true;
      }
      return false ;
   }

}

