using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override void BeforeCompile( )
   {
   }

   public override void AfterCompile( )
   {
   }

   static public void Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\gxCommon.dll", cs_path + @"\gxCommon.rsp");
      sc.Add( @"bin\Developermenu.exe", cs_path + @"\Developermenu.rsp");
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
      if ( ( obj == @"bin\Developermenu.exe" ) )
      {
         if (checkTime(obj, cs_path + @"\Developermenu.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tcliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subtcliente39.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tfilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subtfilme22.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subtfilme27.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tcategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\testado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tcidade.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tmidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tfuncionario.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tastro.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tconftipmidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\tlocacao.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subtlocacao30.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpeestado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpeestado02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpecidade.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpecidade02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpecategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpecategoria04.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpefilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpefilme02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpemidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpemidia02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconscidade.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconscidade02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconsestado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconsestado08.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconscategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconscategoria06.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconsfilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconsfilme08.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconsmidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconsmidia08.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wlogin.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconscliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconscliente10.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpecliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpecliente11.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconsfuncionario.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconsfuncionario12.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpefuncionario.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpefuncionario02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpeastro.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpeastro07.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconsastro.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconsastro07.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wrelfilporcategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wrelclicomdependente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wrelmid.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wconftipmidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwconftipmidia02.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wpelocacao.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwpelocacao11.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0010.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx001020.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0021.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx002110.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0030.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx003010.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0041.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx004110.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0051.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx005111.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0060.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx006008.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0070.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx007010.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0080.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx008010.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx00a0.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx00a008.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx00b0.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx00b012.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx00c0.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx00c020.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx00d1.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx00d120.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wgx0090.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwgx009016.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wmovdocliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\subwmovdocliente06.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\bmenuprincipal.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wreltopdelista.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pverpesfunlogin.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pvalpesfunlogin.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pvercidcodigo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pverclidependente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pretfunlogdados.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pgraconftipmidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\patzlocacao.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\ppevalmidias.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\pdeldependente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rrelfilporcategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rrelclicomdependente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rrelmidporcategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rrelmidporcatfilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdelisdevporcliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdelisdevporfilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdelisdevporcategoria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdelisdevportipdemidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdeliscanporcliente.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdeliscanporfilme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdeliscanportipdemidia.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\rreltopdeliscanporcategoria.cs" ))
            return true;
      }
      if ( ( obj == @"bin\gxCommon.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\gxCommon.rsp" ))
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

