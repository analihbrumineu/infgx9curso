/*
               File: RelTopDeLisDevPorFilme
        Description: Relatório de topo de lista de devoluções por filmes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:34.90
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
   public class rreltopdelisdevporfilme_wrapper : GXJWin
   {
      public rreltopdelisdevporfilme_wrapper( int hnd ,
                                              ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdelisdevporfilme : GXWinProcedure
   {
      public rreltopdelisdevporfilme( int hnd ,
                                      ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevporfilme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rreltopdelisdevporfilme( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevporfilme( IGxContext context ,
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
         rreltopdelisdevporfilme objrreltopdelisdevporfilme;
         objrreltopdelisdevporfilme = new rreltopdelisdevporfilme();
         objrreltopdelisdevporfilme.AV8DatInic = aP0_DatInicial;
         objrreltopdelisdevporfilme.AV9DatFina = aP1_DatFinal;
         objrreltopdelisdevporfilme.AV10Seleca = aP2_Selecao;
         objrreltopdelisdevporfilme.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdelisdevporfilme.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de topo de lista de devoluções por filmes.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV13AuxLoc = "" ;
            AV14Filmes = new GxObjectCollection( context, "SDTFilRelatorio.SDTFilDevolucaoItem", "AgoraVaiCurso", "SdtSDTFilRelatorio_SDTFilDevolucaoItem", "GeneXus.Programs") ;
            /* Using cursor R000P2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0P3 = false ;
               A86LocCodi = R000P2_A86LocCodi[0] ;
               A89LocDatD = R000P2_A89LocDatD[0] ;
               n89LocDatD = R000P2_n89LocDatD[0] ;
               A104LocMid = R000P2_A104LocMid[0] ;
               n104LocMid = R000P2_n104LocMid[0] ;
               A103LocMid = R000P2_A103LocMid[0] ;
               n103LocMid = R000P2_n103LocMid[0] ;
               A89LocDatD = R000P2_A89LocDatD[0] ;
               n89LocDatD = R000P2_n89LocDatD[0] ;
               if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
               {
                  if ( ( String.CompareOrdinal(A104LocMid.TrimEnd(' '), AV13AuxLoc.TrimEnd(' ') ) != 0 ) )
                  {
                     if ( ( String.CompareOrdinal(AV13AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
                     {
                        AV14Filmes.Add(AV15Item, 0);
                     }
                     AV15Item = new SdtSDTFilRelatorio_SDTFilDevolucaoItem(context) ;
                     AV15Item.gxTpr_Filrellocmidfilcodigo = A103LocMid ;
                     AV15Item.gxTpr_Filrellocmidfilnome = A104LocMid ;
                     AV15Item.gxTpr_Filreltotal = 0 ;
                     AV13AuxLoc = A104LocMid ;
                  }
                  while ( (pr_default.getStatus(0) != 101) && ( String.CompareOrdinal(R000P2_A104LocMid[0].TrimEnd(' '), A104LocMid.TrimEnd(' ') ) == 0 ) )
                  {
                     BRK0P3 = false ;
                     A86LocCodi = R000P2_A86LocCodi[0] ;
                     A89LocDatD = R000P2_A89LocDatD[0] ;
                     n89LocDatD = R000P2_n89LocDatD[0] ;
                     A89LocDatD = R000P2_A89LocDatD[0] ;
                     n89LocDatD = R000P2_n89LocDatD[0] ;
                     if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
                     {
                        AV15Item.gxTpr_Filreltotal = (long)(AV15Item.gxTpr_Filreltotal+1) ;
                     }
                     BRK0P3 = true ;
                     pr_default.readNext(0);
                  }
               }
               if ( ! BRK0P3 )
               {
                  BRK0P3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            if ( ( String.CompareOrdinal(AV13AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               AV14Filmes.Add(AV15Item, 0);
            }
            AV14Filmes.Sort("[FilRelTotal]");
            AV16ContSe = 0 ;
            AV25GXV1 = 1 ;
            while ( ( AV25GXV1 <= AV14Filmes.Count ) )
            {
               AV15Item = ((SdtSDTFilRelatorio_SDTFilDevolucaoItem)AV14Filmes.Item(AV25GXV1)) ;
               if ( ( AV16ContSe < AV10Seleca ) )
               {
                  AV11LocMid = AV15Item.gxTpr_Filrellocmidfilnome ;
                  H0P0( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV11LocMid, "@!")), 26, Gx_line+13, 375, Gx_line+28, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  AV12TotDev = AV15Item.gxTpr_Filreltotal ;
                  H0P0( false, 15) ;
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
            H0P0( true, 0) ;
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

      protected void H0P0( bool bFoot ,
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
         GXAsk ask = new GXAsk( "Relatório de topo de lista de devoluções por filmes." , true , new GXAskObject[] {
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
         AV13AuxLoc = "" ;
         AV14Filmes = new GxObjectCollection( context, "SDTFilRelatorio.SDTFilDevolucaoItem", "AgoraVaiCurso", "SdtSDTFilRelatorio_SDTFilDevolucaoItem", "GeneXus.Programs");
         scmdbuf = "" ;
         R000P2_A102LocMid = new int[1] ;
         R000P2_A86LocCodi = new int[1] ;
         R000P2_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         R000P2_n89LocDatD = new bool[] {false} ;
         R000P2_A104LocMid = new String[] {""} ;
         R000P2_n104LocMid = new bool[] {false} ;
         R000P2_A103LocMid = new int[1] ;
         R000P2_n103LocMid = new bool[] {false} ;
         BRK0P3 = false ;
         A86LocCodi = 0 ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         AV15Item = new SdtSDTFilRelatorio_SDTFilDevolucaoItem(context);
         AV16ContSe = 0 ;
         AV25GXV1 = 0 ;
         AV11LocMid = "" ;
         Gx_OldLine = 0 ;
         AV12TotDev = 0 ;
         AV20Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rreltopdelisdevporfilme__default(),
            new Object[][] {
                new Object[] {
               R000P2_A102LocMid, R000P2_A86LocCodi, R000P2_A89LocDatD, R000P2_n89LocDatD, R000P2_A104LocMid, R000P2_n104LocMid, R000P2_A103LocMid, R000P2_n103LocMid
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV20Pgmdes = "Relatório de topo de lista de devoluções por filmes." ;
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
      private DateTime A89LocDatD ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK0P3 ;
      private bool n89LocDatD ;
      private bool n104LocMid ;
      private bool n103LocMid ;
      private String AV13AuxLoc ;
      private String A104LocMid ;
      private String AV11LocMid ;
      private IGxDataStore dsDefault ;
      private IDataReader R000P2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000P2_A102LocMid ;
      private int[] R000P2_A86LocCodi ;
      private DateTime[] R000P2_A89LocDatD ;
      private bool[] R000P2_n89LocDatD ;
      private String[] R000P2_A104LocMid ;
      private bool[] R000P2_n104LocMid ;
      private int[] R000P2_A103LocMid ;
      private bool[] R000P2_n103LocMid ;
      private GxObjectCollection AV14Filmes ;
      private SdtSDTFilRelatorio_SDTFilDevolucaoItem AV15Item ;
   }

   public class rreltopdelisdevporfilme__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmR000P2 ;
          prmR000P2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000P2", "SELECT T1.[LocMidMidCodigo], T1.[LocCodigo], T2.[LocDatDevolucao], T1.[LocMidFilNome], T1.[LocMidFilCodigo] FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) INNER JOIN [LOCACAO] T2 WITH (NOLOCK) ON T2.[LocCodigo] = T1.[LocCodigo]) ORDER BY T1.[LocMidFilNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000P2,100,0,true,false )
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
