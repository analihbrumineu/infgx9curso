/*
               File: GraConfTipMidia
        Description: Gravar configuração de tipo de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:28.19
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
   public class pgraconftipmidia_wrapper : GXJWin
   {
      public pgraconftipmidia_wrapper( int hnd ,
                                       ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pgraconftipmidia : GXWinProcedure
   {
      public pgraconftipmidia( int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pgraconftipmidia( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pgraconftipmidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pgraconftipmidia( IGxContext context ,
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

      public void execute( short aP0_MidTipo ,
                           int aP1_CatCodigo ,
                           decimal aP2_ConfTipValNovo )
      {
         this.AV8MidTipo = aP0_MidTipo;
         this.AV9CatCodi = aP1_CatCodigo;
         this.AV11ConfTi = aP2_ConfTipValNovo;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_MidTipo ,
                                 int aP1_CatCodigo ,
                                 decimal aP2_ConfTipValNovo )
      {
         pgraconftipmidia objpgraconftipmidia;
         objpgraconftipmidia = new pgraconftipmidia();
         objpgraconftipmidia.AV8MidTipo = aP0_MidTipo;
         objpgraconftipmidia.AV9CatCodi = aP1_CatCodigo;
         objpgraconftipmidia.AV11ConfTi = aP2_ConfTipValNovo;
         objpgraconftipmidia.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpgraconftipmidia.executePrivateCatch ));
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
         /* Optimized UPDATE. */
         /* Using cursor P000F2 */
         pr_default.execute(0, new Object[] {n85ConfTip, AV11ConfTi, AV8MidTipo, AV9CatCodi});
         pr_default.close(0);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
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
         n85ConfTip = false ;
         A85ConfTip = (decimal)(0M) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pgraconftipmidia__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8MidTipo ;
      private int AV9CatCodi ;
      private decimal AV11ConfTi ;
      private decimal A85ConfTip ;
      private bool n85ConfTip ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class pgraconftipmidia__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000F2 ;
          prmP000F2 = new Object[] {
          new Object[] {"@ConfTipValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV8MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV9CatCodi",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000F2", "UPDATE [CONFTIPMIDIA] SET [ConfTipValor]=@ConfTipValor  WHERE [MidTipo] = @AV8MidTipo and [CatCodigo] = @AV9CatCodi", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000F2)
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
       }
    }

 }

}
