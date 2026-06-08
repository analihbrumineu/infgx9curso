using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class gxrgzb : GXReorganization
   {
      public gxrgzb( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrgzb( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         /*
            This program controls table creation either for the creation or
            reorganization processes.
            Execute reorganization programs (none if creating the database).
         */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzrrpgm", new   object[]  {"4"}) , null);
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("runpgm", new   object[]  {"C12"}) , null);
         new c12(context ).execute( ) ;
         /* Creating final tables. */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"LOCACAO", ""}) , null);
         cmdBuffer=" DROP TABLE [LOCACAO] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [LOCACAO] ([LocCodigo] int NOT null  IDENTITY(1,1), [LocSituacao] smallint null , [LocDatLocacao] datetime null , [LocDatDevolucao] datetime null , [LocDatCancelamento] datetime null , [LocCliPesCodigo] int null , [LocVenPesCodigo] int null , [LocTotValor] money null , PRIMARY KEY([LocCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Dropping temporary indexes. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         cmdBuffer = "" ;
         /* GeneXus formulas. */
      }

      protected String cmdBuffer ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
   }

}
