/*
               File: RelMidPorCategoria
        Description: Relatório do total de mídias por categoria
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 11:37:29.44
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
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class rrelmidporcategoria_wrapper : GXJWin
   {
      public rrelmidporcategoria_wrapper( int hnd ,
                                          ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rrelmidporcategoria : GXWinProcedure
   {
      public rrelmidporcategoria( int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelmidporcategoria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rrelmidporcategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelmidporcategoria( IGxContext context ,
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
                           int aP1_CatCodInicial ,
                           int aP2_CatCodFinal )
      {
         this.AV11MidTip = aP0_MidTipo;
         this.AV8CatCodI = aP1_CatCodInicial;
         this.AV9CatCodF = aP2_CatCodFinal;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_MidTipo ,
                                 int aP1_CatCodInicial ,
                                 int aP2_CatCodFinal )
      {
         rrelmidporcategoria objrrelmidporcategoria;
         objrrelmidporcategoria = new rrelmidporcategoria();
         objrrelmidporcategoria.AV11MidTip = aP0_MidTipo;
         objrrelmidporcategoria.AV8CatCodI = aP1_CatCodInicial;
         objrrelmidporcategoria.AV9CatCodF = aP2_CatCodFinal;
         objrrelmidporcategoria.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrrelmidporcategoria.executePrivateCatch ));
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
         if (askCanceled) return;
         /* GeneXus formulas */
         /* Output device settings */
         M_top = 0 ;
         M_bot = 6 ;
         P_lines = (int)(66-M_bot) ;
         getPrinter().GxClearAttris() ;
         lineHeight = 15 ;
         PrtOffset = 0 ;
         gxXPage = 96 ;
         gxYPage = 96 ;
         try
         {
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 9, 16838, 11906, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().GxSetDocName("Relatório do total de mídias por categoria") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            if ( ( AV11MidTip == 0 ) )
            {
               AV14MidTip = "Todos" ;
            }
            else if ( ( AV11MidTip == 1 ) )
            {
               AV14MidTip = "DVD" ;
            }
            else if ( ( AV11MidTip == 2 ) )
            {
               AV14MidTip = "Bluray" ;
            }
            else if ( ( AV11MidTip == 3 ) )
            {
               AV14MidTip = "VHS" ;
            }
            else if ( ( AV11MidTip == 4 ) )
            {
               AV14MidTip = "Box" ;
            }
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV11MidTip ,
                                                 A35MidTipo ,
                                                 A32CatCodi ,
                                                 AV8CatCodI ,
                                                 AV9CatCodF },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT
                                                 }
            });
            /* Using cursor R000B2 */
            pr_default.execute(0, new Object[] {AV8CatCodI, AV9CatCodF});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0B3 = false ;
               A32CatCodi = R000B2_A32CatCodi[0] ;
               n32CatCodi = R000B2_n32CatCodi[0] ;
               A33CatNome = R000B2_A33CatNome[0] ;
               n33CatNome = R000B2_n33CatNome[0] ;
               A36MidSitu = R000B2_A36MidSitu[0] ;
               n36MidSitu = R000B2_n36MidSitu[0] ;
               A35MidTipo = R000B2_A35MidTipo[0] ;
               n35MidTipo = R000B2_n35MidTipo[0] ;
               A28FilCodi = R000B2_A28FilCodi[0] ;
               n28FilCodi = R000B2_n28FilCodi[0] ;
               A32CatCodi = R000B2_A32CatCodi[0] ;
               n32CatCodi = R000B2_n32CatCodi[0] ;
               A33CatNome = R000B2_A33CatNome[0] ;
               n33CatNome = R000B2_n33CatNome[0] ;
               AV10CatNom = A33CatNome ;
               AV16CatCod = A32CatCodi ;
               AV12TotMid = 0 ;
               while ( (pr_default.getStatus(0) != 101) && ( String.CompareOrdinal(R000B2_A33CatNome[0].TrimEnd(' '), A33CatNome.TrimEnd(' ') ) == 0 ) && ( R000B2_A32CatCodi[0] == A32CatCodi ) )
               {
                  BRK0B3 = false ;
                  A36MidSitu = R000B2_A36MidSitu[0] ;
                  n36MidSitu = R000B2_n36MidSitu[0] ;
                  A28FilCodi = R000B2_A28FilCodi[0] ;
                  n28FilCodi = R000B2_n28FilCodi[0] ;
                  AV12TotMid = (long)(AV12TotMid+1) ;
                  BRK0B3 = true ;
                  pr_default.readNext(0);
               }
               H0B0( false, 18) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV10CatNom, "@!")), 39, Gx_line+2, 272, Gx_line+17, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV12TotMid), "ZZZZZZZZZ9"), 416, Gx_line+0, 485, Gx_line+15, 2+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+18) ;
               if ( ! BRK0B3 )
               {
                  BRK0B3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0B0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            if ( ( Gx_line > 0 ) )
            {
               /* Close printer file */
               try
               {
                  getPrinter().GxEndPage() ;
                  getPrinter().GxEndDocument() ;
               }
               catch ( GeneXus.Printer.ProcessInterruptedException e )
               {
               }
               endPrinter();
            }
         }
         this.cleanup();
      }

      protected void H0B0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( ( Gx_line + Inc >= P_lines ) )
            {
               if ( ( Gx_page > 0 ) )
               {
                  /* Print footers */
                  Gx_line = P_lines ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Rodapé", 325, Gx_line+13, 369, Gx_line+26, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  if ( ! bFoot )
                  {
                     getPrinter().GxEndPage() ;
                  }
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0 ;
               Gx_line = 0 ;
               Gx_page = (int)(Gx_page+1) ;
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight)) ;
               /* Print headers */
               getPrinter().GxStartPage() ;
               getPrinter().GxDrawLine(26, Gx_line+163, 650, Gx_line+163, 1, 100, 100, 100, 0) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 598, Gx_line+0, 662, Gx_line+15, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 598, Gx_line+13, 662, Gx_line+28, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 598, Gx_line+26, 649, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV22Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 171, Gx_line+27, 495, Gx_line+42, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV8CatCodI), "ZZZZZZZZ9"), 91, Gx_line+65, 166, Gx_line+80, 2) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV9CatCodF), "ZZZZZZZZ9"), 221, Gx_line+65, 298, Gx_line+80, 2) ;
               getPrinter().GxDrawText(AV14MidTip, 143, Gx_line+78, 194, Gx_line+93, 0) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Data:", 559, Gx_line+0, 590, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 559, Gx_line+13, 590, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 546, Gx_line+26, 589, Gx_line+39, 0+256) ;
               getPrinter().GxDrawText("Categoria", 26, Gx_line+67, 80, Gx_line+80, 0+256) ;
               getPrinter().GxDrawText("até", 182, Gx_line+67, 200, Gx_line+80, 0+256) ;
               getPrinter().GxDrawText("Categoria", 26, Gx_line+151, 80, Gx_line+164, 0+256) ;
               getPrinter().GxDrawText("Total de mídias em", 26, Gx_line+78, 134, Gx_line+91, 0+256) ;
               getPrinter().GxDrawText("Total de mídias", 416, Gx_line+151, 504, Gx_line+164, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+164) ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0 ;
               Gx_line = (int)(Gx_line+1) ;
            }
            ToSkip = (int)(ToSkip-1) ;
         }
         getPrinter().setPage(Gx_page);
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      private bool doAsk( )
      {
         GXAsk ask = new GXAsk( "Relatório do total de mídias por categoria" , true , new GXAskObject[] {
         });
         Gx_out = ask.getOutput();
         return ask.getConfirmed();
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
         askCanceled = false ;
         M_top = 0 ;
         M_bot = 0 ;
         Gx_line = 0 ;
         ToSkip = 0 ;
         PrtOffset = 0 ;
         AV14MidTip = "" ;
         scmdbuf = "" ;
         A35MidTipo = 0 ;
         A32CatCodi = 0 ;
         R000B2_A37MidCodi = new int[1] ;
         R000B2_A32CatCodi = new int[1] ;
         R000B2_n32CatCodi = new bool[] {false} ;
         R000B2_A33CatNome = new String[] {""} ;
         R000B2_n33CatNome = new bool[] {false} ;
         R000B2_A36MidSitu = new short[1] ;
         R000B2_n36MidSitu = new bool[] {false} ;
         R000B2_A35MidTipo = new short[1] ;
         R000B2_n35MidTipo = new bool[] {false} ;
         R000B2_A28FilCodi = new int[1] ;
         R000B2_n28FilCodi = new bool[] {false} ;
         BRK0B3 = false ;
         n32CatCodi = false ;
         A33CatNome = "" ;
         n33CatNome = false ;
         A36MidSitu = 0 ;
         n36MidSitu = false ;
         n35MidTipo = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         AV10CatNom = "" ;
         AV16CatCod = 0 ;
         AV12TotMid = 0 ;
         Gx_OldLine = 0 ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         AV22Pgmdes = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rrelmidporcategoria__default(),
            new Object[][] {
                new Object[] {
               R000B2_A37MidCodi, R000B2_A32CatCodi, R000B2_n32CatCodi, R000B2_A33CatNome, R000B2_n33CatNome, R000B2_A36MidSitu, R000B2_n36MidSitu, R000B2_A35MidTipo, R000B2_n35MidTipo, R000B2_A28FilCodi,
               R000B2_n28FilCodi
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         AV22Pgmdes = "Relatório do total de mídias por categoria" ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         if ( ( String.CompareOrdinal(Gx_dev.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            Gx_out = "PRN" ;
         }
         else
         {
            Gx_out = "SCR" ;
         }
         askCanceled = !doAsk();
      }

      private short AV11MidTip ;
      private short A35MidTipo ;
      private short A36MidSitu ;
      private int AV8CatCodI ;
      private int AV9CatCodF ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A32CatCodi ;
      private int A28FilCodi ;
      private int AV16CatCod ;
      private int Gx_OldLine ;
      private long AV12TotMid ;
      private String scmdbuf ;
      private String Gx_time ;
      private String AV22Pgmdes ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK0B3 ;
      private bool n32CatCodi ;
      private bool n33CatNome ;
      private bool n36MidSitu ;
      private bool n35MidTipo ;
      private bool n28FilCodi ;
      private String AV14MidTip ;
      private String A33CatNome ;
      private String AV10CatNom ;
      private IGxDataStore dsDefault ;
      private IDataReader R000B2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000B2_A37MidCodi ;
      private int[] R000B2_A32CatCodi ;
      private bool[] R000B2_n32CatCodi ;
      private String[] R000B2_A33CatNome ;
      private bool[] R000B2_n33CatNome ;
      private short[] R000B2_A36MidSitu ;
      private bool[] R000B2_n36MidSitu ;
      private short[] R000B2_A35MidTipo ;
      private bool[] R000B2_n35MidTipo ;
      private int[] R000B2_A28FilCodi ;
      private bool[] R000B2_n28FilCodi ;
   }

   public class rrelmidporcategoria__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_R000B2( short AV11MidTip ,
                                           short A35MidTipo ,
                                           int A32CatCodi ,
                                           int AV8CatCodI ,
                                           int AV9CatCodF )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[MidCodigo], T2.[CatCodigo], T3.[CatNome], T1.[MidSituacao], T1.[MidTipo], T1.[FilCodigo] FROM (([MIDIA] T1 WITH (NOLOCK) LEFT JOIN [FILME] T2 WITH (NOLOCK) ON T2.[FilCodigo] = T1.[FilCodigo]) LEFT JOIN [CATEGORIA] T3 WITH (NOLOCK) ON T3.[CatCodigo] = T2.[CatCodigo])" ;
         scmdbuf = scmdbuf + " WHERE (T2.[CatCodigo] >= " + StringUtil.Str( (decimal)(AV8CatCodI), 9, 0) + " and T2.[CatCodigo] <= " + StringUtil.Str( (decimal)(AV9CatCodF), 9, 0) + ")" ;
         sWhereString = "" ;
         if ( ( AV11MidTip != 0 ) )
         {
            sWhereString = sWhereString + " and (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV11MidTip), 1, 0) + ")" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T3.[CatNome], T2.[CatCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_R000B2( (short)dynConstraints[0] , (short)dynConstraints[1] , (int)dynConstraints[2] , (int)dynConstraints[3] , (int)dynConstraints[4] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmR000B2 ;
          prmR000B2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000B2,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
