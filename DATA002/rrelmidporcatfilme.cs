/*
               File: RelMidPorCatFilme
        Description: Relatório de mídia por categoria/filme.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:4.72
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
   public class rrelmidporcatfilme_wrapper : GXJWin
   {
      public rrelmidporcatfilme_wrapper( int hnd ,
                                         ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rrelmidporcatfilme : GXWinProcedure
   {
      public rrelmidporcatfilme( int hnd ,
                                 ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelmidporcatfilme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rrelmidporcatfilme( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelmidporcatfilme( IGxContext context ,
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
         rrelmidporcatfilme objrrelmidporcatfilme;
         objrrelmidporcatfilme = new rrelmidporcatfilme();
         objrrelmidporcatfilme.AV11MidTip = aP0_MidTipo;
         objrrelmidporcatfilme.AV8CatCodI = aP1_CatCodInicial;
         objrrelmidporcatfilme.AV9CatCodF = aP2_CatCodFinal;
         objrrelmidporcatfilme.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrrelmidporcatfilme.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de mídia por categoria/filme.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            if ( ( AV11MidTip == 0 ) )
            {
               AV15MidTip = "Todos" ;
            }
            else if ( ( AV11MidTip == 1 ) )
            {
               AV15MidTip = "DVD" ;
            }
            else if ( ( AV11MidTip == 2 ) )
            {
               AV15MidTip = "Bluray" ;
            }
            else if ( ( AV11MidTip == 3 ) )
            {
               AV15MidTip = "VHS" ;
            }
            else if ( ( AV11MidTip == 4 ) )
            {
               AV15MidTip = "Box" ;
            }
            /* Using cursor R000C2 */
            pr_default.execute(0, new Object[] {AV8CatCodI, AV9CatCodF});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0C3 = false ;
               A33CatNome = R000C2_A33CatNome[0] ;
               n33CatNome = R000C2_n33CatNome[0] ;
               A32CatCodi = R000C2_A32CatCodi[0] ;
               n32CatCodi = R000C2_n32CatCodi[0] ;
               A30FilSitu = R000C2_A30FilSitu[0] ;
               n30FilSitu = R000C2_n30FilSitu[0] ;
               A28FilCodi = R000C2_A28FilCodi[0] ;
               n28FilCodi = R000C2_n28FilCodi[0] ;
               A29FilNome = R000C2_A29FilNome[0] ;
               n29FilNome = R000C2_n29FilNome[0] ;
               A33CatNome = R000C2_A33CatNome[0] ;
               n33CatNome = R000C2_n33CatNome[0] ;
               AV10CatNom = A33CatNome ;
               AV16CatCod = A32CatCodi ;
               H0C0( false, 26) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV10CatNom, "@!")), 39, Gx_line+13, 168, Gx_line+26, 0) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+26) ;
               while ( (pr_default.getStatus(0) != 101) && ( String.CompareOrdinal(R000C2_A33CatNome[0].TrimEnd(' '), A33CatNome.TrimEnd(' ') ) == 0 ) && ( R000C2_A32CatCodi[0] == A32CatCodi ) )
               {
                  BRK0C3 = false ;
                  A30FilSitu = R000C2_A30FilSitu[0] ;
                  n30FilSitu = R000C2_n30FilSitu[0] ;
                  A28FilCodi = R000C2_A28FilCodi[0] ;
                  n28FilCodi = R000C2_n28FilCodi[0] ;
                  A29FilNome = R000C2_A29FilNome[0] ;
                  n29FilNome = R000C2_n29FilNome[0] ;
                  if ( ( AV16CatCod == A32CatCodi ) )
                  {
                     AV14FilCod = A28FilCodi ;
                     AV12FilNom = A29FilNome ;
                     AV13TotMid = 0 ;
                     pr_default.dynParam(1, new Object[]{ new Object[]{
                                                          AV11MidTip ,
                                                          A35MidTipo ,
                                                          A28FilCodi },
                                                          new int[] {
                                                          TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN
                                                          }
                     });
                     /* Using cursor R000C3 */
                     pr_default.execute(1, new Object[] {n28FilCodi, A28FilCodi});
                     while ( (pr_default.getStatus(1) != 101) )
                     {
                        A35MidTipo = R000C3_A35MidTipo[0] ;
                        n35MidTipo = R000C3_n35MidTipo[0] ;
                        A36MidSitu = R000C3_A36MidSitu[0] ;
                        n36MidSitu = R000C3_n36MidSitu[0] ;
                        AV13TotMid = (long)(AV13TotMid+1) ;
                        pr_default.readNext(1);
                     }
                     pr_default.close(1);
                     H0C0( false, 26) ;
                     getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV12FilNom, "@!")), 195, Gx_line+0, 480, Gx_line+13, 0) ;
                     getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV13TotMid), "ZZZZZZZZZ9"), 494, Gx_line+0, 563, Gx_line+13, 2) ;
                     Gx_OldLine = Gx_line ;
                     Gx_line = (int)(Gx_line+26) ;
                  }
                  BRK0C3 = true ;
                  pr_default.readNext(0);
               }
               if ( ! BRK0C3 )
               {
                  BRK0C3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0C0( true, 0) ;
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

      protected void H0C0( bool bFoot ,
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
                  getPrinter().GxDrawText("Rodapé", 312, Gx_line+0, 356, Gx_line+13, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+40) ;
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
               getPrinter().GxDrawLine(26, Gx_line+156, 650, Gx_line+156, 1, 100, 100, 100, 0) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 595, Gx_line+0, 659, Gx_line+15, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 595, Gx_line+13, 659, Gx_line+28, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 595, Gx_line+26, 646, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV22Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 171, Gx_line+20, 495, Gx_line+35, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV8CatCodI), "ZZZZZZZZ9"), 91, Gx_line+58, 166, Gx_line+73, 2) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV9CatCodF), "ZZZZZZZZ9"), 221, Gx_line+58, 298, Gx_line+73, 2) ;
               getPrinter().GxDrawText(AV15MidTip, 143, Gx_line+78, 194, Gx_line+93, 0) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Data:", 556, Gx_line+0, 587, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 556, Gx_line+13, 587, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 543, Gx_line+26, 586, Gx_line+39, 0+256) ;
               getPrinter().GxDrawText("Categoria", 26, Gx_line+60, 80, Gx_line+73, 0+256) ;
               getPrinter().GxDrawText("até", 182, Gx_line+60, 200, Gx_line+73, 0+256) ;
               getPrinter().GxDrawText("Categoria", 39, Gx_line+144, 93, Gx_line+157, 0+256) ;
               getPrinter().GxDrawText("Total de mídias em", 26, Gx_line+80, 134, Gx_line+93, 0+256) ;
               getPrinter().GxDrawText("Total de mídias", 494, Gx_line+144, 582, Gx_line+157, 0+256) ;
               getPrinter().GxDrawText("Filme", 195, Gx_line+144, 224, Gx_line+157, 0+256) ;
               getPrinter().GxDrawText("em cada título", 204, Gx_line+80, 286, Gx_line+93, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+169) ;
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
         GXAsk ask = new GXAsk( "Relatório de mídia por categoria/filme." , true , new GXAskObject[] {
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
         AV15MidTip = "" ;
         scmdbuf = "" ;
         R000C2_A33CatNome = new String[] {""} ;
         R000C2_n33CatNome = new bool[] {false} ;
         R000C2_A32CatCodi = new int[1] ;
         R000C2_n32CatCodi = new bool[] {false} ;
         R000C2_A30FilSitu = new short[1] ;
         R000C2_n30FilSitu = new bool[] {false} ;
         R000C2_A28FilCodi = new int[1] ;
         R000C2_n28FilCodi = new bool[] {false} ;
         R000C2_A29FilNome = new String[] {""} ;
         R000C2_n29FilNome = new bool[] {false} ;
         BRK0C3 = false ;
         A33CatNome = "" ;
         n33CatNome = false ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         A30FilSitu = 0 ;
         n30FilSitu = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         A29FilNome = "" ;
         n29FilNome = false ;
         AV10CatNom = "" ;
         AV16CatCod = 0 ;
         Gx_OldLine = 0 ;
         AV14FilCod = 0 ;
         AV12FilNom = "" ;
         AV13TotMid = 0 ;
         A35MidTipo = 0 ;
         R000C3_A37MidCodi = new int[1] ;
         R000C3_A28FilCodi = new int[1] ;
         R000C3_n28FilCodi = new bool[] {false} ;
         R000C3_A35MidTipo = new short[1] ;
         R000C3_n35MidTipo = new bool[] {false} ;
         R000C3_A36MidSitu = new short[1] ;
         R000C3_n36MidSitu = new bool[] {false} ;
         n35MidTipo = false ;
         A36MidSitu = 0 ;
         n36MidSitu = false ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         AV22Pgmdes = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rrelmidporcatfilme__default(),
            new Object[][] {
                new Object[] {
               R000C2_A33CatNome, R000C2_n33CatNome, R000C2_A32CatCodi, R000C2_n32CatCodi, R000C2_A30FilSitu, R000C2_n30FilSitu, R000C2_A28FilCodi, R000C2_A29FilNome, R000C2_n29FilNome
               }
               , new Object[] {
               R000C3_A37MidCodi, R000C3_A28FilCodi, R000C3_n28FilCodi, R000C3_A35MidTipo, R000C3_n35MidTipo, R000C3_A36MidSitu, R000C3_n36MidSitu
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         AV22Pgmdes = "Relatório de mídia por categoria/filme." ;
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
      private short A30FilSitu ;
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
      private int AV14FilCod ;
      private long AV13TotMid ;
      private String scmdbuf ;
      private String Gx_time ;
      private String AV22Pgmdes ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK0C3 ;
      private bool n33CatNome ;
      private bool n32CatCodi ;
      private bool n30FilSitu ;
      private bool n28FilCodi ;
      private bool n29FilNome ;
      private bool n35MidTipo ;
      private bool n36MidSitu ;
      private String AV15MidTip ;
      private String A33CatNome ;
      private String A29FilNome ;
      private String AV10CatNom ;
      private String AV12FilNom ;
      private IGxDataStore dsDefault ;
      private IDataReader R000C2 ;
      private IDataStoreProvider pr_default ;
      private String[] R000C2_A33CatNome ;
      private bool[] R000C2_n33CatNome ;
      private int[] R000C2_A32CatCodi ;
      private bool[] R000C2_n32CatCodi ;
      private short[] R000C2_A30FilSitu ;
      private bool[] R000C2_n30FilSitu ;
      private int[] R000C2_A28FilCodi ;
      private bool[] R000C2_n28FilCodi ;
      private String[] R000C2_A29FilNome ;
      private bool[] R000C2_n29FilNome ;
      private IDataReader R000C3 ;
      private int[] R000C3_A37MidCodi ;
      private int[] R000C3_A28FilCodi ;
      private bool[] R000C3_n28FilCodi ;
      private short[] R000C3_A35MidTipo ;
      private bool[] R000C3_n35MidTipo ;
      private short[] R000C3_A36MidSitu ;
      private bool[] R000C3_n36MidSitu ;
   }

   public class rrelmidporcatfilme__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_R000C3( short AV11MidTip ,
                                           short A35MidTipo ,
                                           int A28FilCodi )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [MidCodigo], [FilCodigo], [MidTipo], [MidSituacao] FROM [MIDIA] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([FilCodigo] = " + StringUtil.Str( (decimal)(A28FilCodi), 9, 0) + ")" ;
         sWhereString = "" ;
         if ( ( AV11MidTip != 0 ) )
         {
            sWhereString = sWhereString + " and ([MidTipo] = " + StringUtil.Str( (decimal)(AV11MidTip), 1, 0) + ")" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [FilCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_R000C3( (short)dynConstraints[0] , (short)dynConstraints[1] , (int)dynConstraints[2] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmR000C2 ;
          prmR000C2 = new Object[] {
          new Object[] {"@AV8CatCodI",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9CatCodF",SqlDbType.Int,9,0}
          } ;
          Object[] prmR000C3 ;
          prmR000C3 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000C2", "SELECT T2.[CatNome], T1.[CatCodigo], T1.[FilSituacao], T1.[FilCodigo], T1.[FilNome] FROM ([FILME] T1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = T1.[CatCodigo]) WHERE T1.[CatCodigo] >= @AV8CatCodI and T1.[CatCodigo] <= @AV9CatCodF ORDER BY T2.[CatNome], T1.[CatCodigo], T1.[FilNome], T1.[FilCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000C2,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("R000C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000C3,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                break;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
