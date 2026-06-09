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
   public class gxrgzc : GXReorganization
   {
      public gxrgzc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrgzc( IGxContext context )
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
            Rename auxiliary tables to the appropriate name.
         */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzrnmtbl", new   object[]  {"6"}) , null);
         /* Adding attributes to tables' structure. */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzbldidx", new   object[]  {"7"}) , null);
         /* Indices for table LOCACAOLOCACAOMIDIA */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("creaindx", new   object[]  {"ILOCACAOLOCACAOMIDIA1"}) , null);
         cmdBuffer=" DROP INDEX [LOCACAOLOCACAOMIDIA].[ILOCACAOLOCACAOMIDIA1] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE NONCLUSTERED INDEX [ILOCACAOLOCACAOMIDIA1] ON [LOCACAOLOCACAOMIDIA] ([LocMidCatCodigo] ) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Referential constraints on table LOCACAOLOCACAOMIDIA */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzdroptbl", new   object[]  {"8"}) , null);
         /* Dropping attributes from tables' structure. */
         /* Dropping removed tables */
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
