/*
               File: DelDependente
        Description: Deletar dependentes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:5.77
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pdeldependente_wrapper : GXJWin
   {
      public pdeldependente_wrapper( int hnd ,
                                     ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pdeldependente : GXWinProcedure
   {
      public pdeldependente( int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pdeldependente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pdeldependente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pdeldependente( IGxContext context ,
                             int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PesDepCodigo )
      {
         this.AV8PesDepC = aP0_PesDepCodigo;
         initialize();
         executePrivate();
         aP0_PesDepCodigo=this.AV8PesDepC;
      }

      public void executeSubmit( ref int aP0_PesDepCodigo )
      {
         pdeldependente objpdeldependente;
         objpdeldependente = new pdeldependente();
         objpdeldependente.AV8PesDepC = aP0_PesDepCodigo;
         objpdeldependente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpdeldependente.executePrivateCatch ));
         aP0_PesDepCodigo=this.AV8PesDepC;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e  )
         {
            GXUtil.SaveToEventLog( "AgoraVaiCurso", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Optimized DELETE. */
         /* Using cursor P000N2 */
         pr_default.execute(0, new Object[] {AV8PesDepC});
         pr_default.close(0);
         /* End optimized DELETE. */
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV8PesDepC = AV8PesDepC;
         context.CommitDataStores("PDelDependente");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pdeldependente__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV8PesDepC ;
      private IGxDataStore dsDefault ;
      private int aP0_PesDepCodigo ;
      private IDataStoreProvider pr_default ;
   }

   public class pdeldependente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmP000N2 ;
          prmP000N2 = new Object[] {
          new Object[] {"@AV8PesDepC",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000N2", "DELETE FROM [CLIENTEDEPENDENTE]  WHERE [PesDepCodigo] = @AV8PesDepC", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000N2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
