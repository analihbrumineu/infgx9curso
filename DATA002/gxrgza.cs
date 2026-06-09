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
   public class gxrgza : GXReorganization
   {
      public gxrgza( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrgza( IGxContext context )
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
            This is the first program in the reorganization process.
            It must be compiled and run before any other reorganization
            program.
         */
         /* Lock tables */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzlcktb", new   object[]  {"1"}) , null);
         /* Load data into tables. */
         /* Drop integrity constraints (if any). */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzdic", new   object[]  {"2"}) , null);
         /* Create new and temporary tables. */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzctnt", new   object[]  {"3"}) , null);
         /* Creating temporary indexes. */
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
         /* GeneXus formulas. */
      }

      protected IGxDataStore dsDefault ;
   }

}
