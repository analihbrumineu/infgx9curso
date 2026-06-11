/*
               File: RelTopDeLisCanPorFilme
        Description: Relatório de topo de lista sobre total de cancelamentos por filme.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:26.12
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
   public class rreltopdeliscanporfilme_wrapper : GXJWin
   {
      public rreltopdeliscanporfilme_wrapper( int hnd ,
                                              ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdeliscanporfilme : GXWinProcedure
   {
      public rreltopdeliscanporfilme( int hnd ,
                                      ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdeliscanporfilme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rreltopdeliscanporfilme( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdeliscanporfilme( IGxContext context ,
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

      public void execute( DateTime aP0_DatInicial ,
                           DateTime aP1_DatFinal ,
                           long aP2_Selecao )
      {
         this.AV8DatInic = aP0_DatInicial;
         this.AV9DatFina = aP1_DatFinal;
         this.AV10Seleca = aP2_Selecao;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_DatInicial ,
                                 DateTime aP1_DatFinal ,
                                 long aP2_Selecao )
      {
         rreltopdeliscanporfilme objrreltopdeliscanporfilme;
         objrreltopdeliscanporfilme = new rreltopdeliscanporfilme();
         objrreltopdeliscanporfilme.AV8DatInic = aP0_DatInicial;
         objrreltopdeliscanporfilme.AV9DatFina = aP1_DatFinal;
         objrreltopdeliscanporfilme.AV10Seleca = aP2_Selecao;
         objrreltopdeliscanporfilme.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdeliscanporfilme.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de topo de lista sobre total de cancelamentos por filme.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV15AuxLoc = "" ;
            AV13Filmes = new GxObjectCollection( context, "SDTFilRelatorio.SDTFilDevolucaoItem", "AgoraVaiCurso", "SdtSDTFilRelatorio_SDTFilDevolucaoItem", "GeneXus.Programs") ;
            /* Using cursor R000T2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0T3 = false ;
               A86LocCodi = R000T2_A86LocCodi[0] ;
               A90LocDatC = R000T2_A90LocDatC[0] ;
               n90LocDatC = R000T2_n90LocDatC[0] ;
               A104LocMid = R000T2_A104LocMid[0] ;
               n104LocMid = R000T2_n104LocMid[0] ;
               A103LocMid = R000T2_A103LocMid[0] ;
               n103LocMid = R000T2_n103LocMid[0] ;
               A90LocDatC = R000T2_A90LocDatC[0] ;
               n90LocDatC = R000T2_n90LocDatC[0] ;
               if ( ( A90LocDatC >= AV8DatInic ) && ( A90LocDatC <= AV9DatFina ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
               {
                  if ( ( String.CompareOrdinal(A104LocMid.TrimEnd(' '), AV15AuxLoc.TrimEnd(' ') ) != 0 ) )
                  {
                     if ( ( String.CompareOrdinal(AV15AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
                     {
                        AV13Filmes.Add(AV14Item, 0);
                     }
                     AV14Item = new SdtSDTFilRelatorio_SDTFilDevolucaoItem(context) ;
                     AV14Item.gxTpr_Filrellocmidfilcodigo = A103LocMid ;
                     AV14Item.gxTpr_Filrellocmidfilnome = A104LocMid ;
                     AV14Item.gxTpr_Filreltotal = 0 ;
                     AV15AuxLoc = A104LocMid ;
                  }
                  while ( (pr_default.getStatus(0) != 101) && ( String.CompareOrdinal(R000T2_A104LocMid[0].TrimEnd(' '), A104LocMid.TrimEnd(' ') ) == 0 ) )
                  {
                     BRK0T3 = false ;
                     A86LocCodi = R000T2_A86LocCodi[0] ;
                     A90LocDatC = R000T2_A90LocDatC[0] ;
                     n90LocDatC = R000T2_n90LocDatC[0] ;
                     A90LocDatC = R000T2_A90LocDatC[0] ;
                     n90LocDatC = R000T2_n90LocDatC[0] ;
                     if ( ( A90LocDatC >= AV8DatInic ) && ( A90LocDatC <= AV9DatFina ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
                     {
                        AV14Item.gxTpr_Filreltotal = (long)(AV14Item.gxTpr_Filreltotal+1) ;
                     }
                     BRK0T3 = true ;
                     pr_default.readNext(0);
                  }
               }
               if ( ! BRK0T3 )
               {
                  BRK0T3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            if ( ( String.CompareOrdinal(AV15AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               AV13Filmes.Add(AV14Item, 0);
            }
            AV13Filmes.Sort("[FilRelTotal]");
            AV16ContSe = 0 ;
            AV25GXV1 = 1 ;
            while ( ( AV25GXV1 <= AV13Filmes.Count ) )
            {
               AV14Item = ((SdtSDTFilRelatorio_SDTFilDevolucaoItem)AV13Filmes.Item(AV25GXV1)) ;
               if ( ( AV16ContSe < AV10Seleca ) )
               {
                  AV11LocMid = AV14Item.gxTpr_Filrellocmidfilnome ;
                  H0T0( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV11LocMid, "@!")), 26, Gx_line+13, 375, Gx_line+28, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  AV12TotDev = AV14Item.gxTpr_Filreltotal ;
                  H0T0( false, 15) ;
                  getPrinter().GxDrawLine(52, Gx_line+12, 650, Gx_line+12, 1, 200, 200, 200, 0) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV12TotDev), "ZZZZZZZZZ9"), 559, Gx_line+0, 628, Gx_line+15, 2+256) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Total", 507, Gx_line+0, 536, Gx_line+13, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+15) ;
                  AV16ContSe = (long)(AV16ContSe+1) ;
               }
               else
               {
                  if (true) break;
               }
               AV25GXV1 = (int)(AV25GXV1+1) ;
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0T0( true, 0) ;
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

      protected void H0T0( bool bFoot ,
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
                  getPrinter().GxDrawLine(26, Gx_line+13, 650, Gx_line+13, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Rodape", 325, Gx_line+26, 369, Gx_line+39, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+52) ;
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
               getPrinter().GxDrawLine(26, Gx_line+194, 650, Gx_line+194, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.Format( AV8DatInic, "99/99/9999"), 65, Gx_line+91, 134, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( AV9DatFina, "99/99/9999"), 169, Gx_line+91, 238, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV10Seleca), "ZZZZZZZZZ9"), 91, Gx_line+117, 160, Gx_line+132, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 606, Gx_line+26, 657, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV20Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 91, Gx_line+52, 597, Gx_line+67, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 611, Gx_line+0, 666, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 611, Gx_line+13, 666, Gx_line+28, 0+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("De", 39, Gx_line+91, 55, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("até", 143, Gx_line+91, 161, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("Seleção", 39, Gx_line+117, 85, Gx_line+130, 0+256) ;
               getPrinter().GxDrawText("Filme", 26, Gx_line+182, 55, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("Data:", 567, Gx_line+0, 598, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 567, Gx_line+13, 598, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 554, Gx_line+26, 597, Gx_line+39, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+195) ;
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
         GXAsk ask = new GXAsk( "Relatório de topo de lista sobre total de cancelamentos por filme." , true , new GXAskObject[] {
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
         AV15AuxLoc = "" ;
         AV13Filmes = new GxObjectCollection( context, "SDTFilRelatorio.SDTFilDevolucaoItem", "AgoraVaiCurso", "SdtSDTFilRelatorio_SDTFilDevolucaoItem", "GeneXus.Programs");
         scmdbuf = "" ;
         R000T2_A102LocMid = new int[1] ;
         R000T2_A86LocCodi = new int[1] ;
         R000T2_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         R000T2_n90LocDatC = new bool[] {false} ;
         R000T2_A104LocMid = new String[] {""} ;
         R000T2_n104LocMid = new bool[] {false} ;
         R000T2_A103LocMid = new int[1] ;
         R000T2_n103LocMid = new bool[] {false} ;
         BRK0T3 = false ;
         A86LocCodi = 0 ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         AV14Item = new SdtSDTFilRelatorio_SDTFilDevolucaoItem(context);
         AV16ContSe = 0 ;
         AV25GXV1 = 0 ;
         AV11LocMid = "" ;
         Gx_OldLine = 0 ;
         AV12TotDev = 0 ;
         AV20Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rreltopdeliscanporfilme__default(),
            new Object[][] {
                new Object[] {
               R000T2_A102LocMid, R000T2_A86LocCodi, R000T2_A90LocDatC, R000T2_n90LocDatC, R000T2_A104LocMid, R000T2_n104LocMid, R000T2_A103LocMid, R000T2_n103LocMid
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV20Pgmdes = "Relatório de topo de lista sobre total de cancelamentos por filme." ;
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

      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A86LocCodi ;
      private int A103LocMid ;
      private int AV25GXV1 ;
      private int Gx_OldLine ;
      private long AV10Seleca ;
      private long AV16ContSe ;
      private long AV12TotDev ;
      private String scmdbuf ;
      private String AV20Pgmdes ;
      private String Gx_time ;
      private DateTime AV8DatInic ;
      private DateTime AV9DatFina ;
      private DateTime A90LocDatC ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK0T3 ;
      private bool n90LocDatC ;
      private bool n104LocMid ;
      private bool n103LocMid ;
      private String AV15AuxLoc ;
      private String A104LocMid ;
      private String AV11LocMid ;
      private IGxDataStore dsDefault ;
      private IDataReader R000T2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000T2_A102LocMid ;
      private int[] R000T2_A86LocCodi ;
      private DateTime[] R000T2_A90LocDatC ;
      private bool[] R000T2_n90LocDatC ;
      private String[] R000T2_A104LocMid ;
      private bool[] R000T2_n104LocMid ;
      private int[] R000T2_A103LocMid ;
      private bool[] R000T2_n103LocMid ;
      private GxObjectCollection AV13Filmes ;
      private SdtSDTFilRelatorio_SDTFilDevolucaoItem AV14Item ;
   }

   public class rreltopdeliscanporfilme__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmR000T2 ;
          prmR000T2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000T2", "SELECT T1.[LocMidMidCodigo], T1.[LocCodigo], T2.[LocDatCancelamento], T1.[LocMidFilNome], T1.[LocMidFilCodigo] FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) INNER JOIN [LOCACAO] T2 WITH (NOLOCK) ON T2.[LocCodigo] = T1.[LocCodigo]) ORDER BY T1.[LocMidFilNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000T2,100,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((int[]) buf[6])[0] = rslt.getInt(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
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
