/*
               File: RelTopDeLisCanPorCategoria
        Description: Relatório de topo de lista sobre total de cancelamentos por categoria.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:28.95
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
   public class rreltopdeliscanporcategoria_wrapper : GXJWin
   {
      public rreltopdeliscanporcategoria_wrapper( int hnd ,
                                                  ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdeliscanporcategoria : GXWinProcedure
   {
      public rreltopdeliscanporcategoria( int hnd ,
                                          ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdeliscanporcategoria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rreltopdeliscanporcategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdeliscanporcategoria( IGxContext context ,
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
         rreltopdeliscanporcategoria objrreltopdeliscanporcategoria;
         objrreltopdeliscanporcategoria = new rreltopdeliscanporcategoria();
         objrreltopdeliscanporcategoria.AV8DatInic = aP0_DatInicial;
         objrreltopdeliscanporcategoria.AV9DatFina = aP1_DatFinal;
         objrreltopdeliscanporcategoria.AV10Seleca = aP2_Selecao;
         objrreltopdeliscanporcategoria.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdeliscanporcategoria.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de topo de lista sobre total de cancelamentos por categoria.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV13AuxLoc = 0 ;
            AV14Catego = new GxObjectCollection( context, "SDTCatRelatorio.SDTCatDevolucaoItem", "AgoraVaiCurso", "SdtSDTCatRelatorio_SDTCatDevolucaoItem", "GeneXus.Programs") ;
            /* Using cursor R000V2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0V3 = false ;
               A86LocCodi = R000V2_A86LocCodi[0] ;
               A90LocDatC = R000V2_A90LocDatC[0] ;
               n90LocDatC = R000V2_n90LocDatC[0] ;
               A105LocMid = R000V2_A105LocMid[0] ;
               n105LocMid = R000V2_n105LocMid[0] ;
               A118LocMid = R000V2_A118LocMid[0] ;
               n118LocMid = R000V2_n118LocMid[0] ;
               A90LocDatC = R000V2_A90LocDatC[0] ;
               n90LocDatC = R000V2_n90LocDatC[0] ;
               A118LocMid = R000V2_A118LocMid[0] ;
               n118LocMid = R000V2_n118LocMid[0] ;
               if ( ( A90LocDatC >= AV8DatInic ) && ( A90LocDatC <= AV9DatFina ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
               {
                  if ( ( A105LocMid != AV13AuxLoc ) )
                  {
                     if ( ( AV13AuxLoc != 0 ) )
                     {
                        AV14Catego.Add(AV15Item, 0);
                     }
                     AV15Item = new SdtSDTCatRelatorio_SDTCatDevolucaoItem(context) ;
                     AV15Item.gxTpr_Catrellocmidcatcodigo = A105LocMid ;
                     AV15Item.gxTpr_Catrelcatnome = A118LocMid ;
                     AV15Item.gxTpr_Catreltotal = 0 ;
                     AV13AuxLoc = A105LocMid ;
                  }
                  while ( (pr_default.getStatus(0) != 101) && ( R000V2_A105LocMid[0] == A105LocMid ) )
                  {
                     BRK0V3 = false ;
                     A86LocCodi = R000V2_A86LocCodi[0] ;
                     A90LocDatC = R000V2_A90LocDatC[0] ;
                     n90LocDatC = R000V2_n90LocDatC[0] ;
                     A90LocDatC = R000V2_A90LocDatC[0] ;
                     n90LocDatC = R000V2_n90LocDatC[0] ;
                     if ( ( A90LocDatC >= AV8DatInic ) && ( A90LocDatC <= AV9DatFina ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
                     {
                        AV15Item.gxTpr_Catreltotal = (long)(AV15Item.gxTpr_Catreltotal+1) ;
                     }
                     BRK0V3 = true ;
                     pr_default.readNext(0);
                  }
               }
               if ( ! BRK0V3 )
               {
                  BRK0V3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            if ( ( AV13AuxLoc != 0 ) )
            {
               AV14Catego.Add(AV15Item, 0);
            }
            AV14Catego.Sort("[CatRelTotal]");
            AV16ContSe = 0 ;
            AV25GXV1 = 1 ;
            while ( ( AV25GXV1 <= AV14Catego.Count ) )
            {
               AV15Item = ((SdtSDTCatRelatorio_SDTCatDevolucaoItem)AV14Catego.Item(AV25GXV1)) ;
               if ( ( AV16ContSe < AV10Seleca ) )
               {
                  AV11CatNom = AV15Item.gxTpr_Catrelcatnome ;
                  H0V0( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV11CatNom, "@!")), 39, Gx_line+13, 388, Gx_line+28, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  AV12TotDev = AV15Item.gxTpr_Catreltotal ;
                  H0V0( false, 26) ;
                  getPrinter().GxDrawLine(52, Gx_line+0, 650, Gx_line+0, 1, 200, 200, 200, 0) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV12TotDev), "ZZZZZZZZZ9"), 581, Gx_line+7, 650, Gx_line+22, 2+256) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Total", 539, Gx_line+8, 568, Gx_line+21, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+26) ;
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
            H0V0( true, 0) ;
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

      protected void H0V0( bool bFoot ,
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
               getPrinter().GxDrawText(StringUtil.Format( AV8DatInic, "99/99/9999"), 64, Gx_line+91, 133, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( AV9DatFina, "99/99/9999"), 169, Gx_line+91, 238, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV10Seleca), "ZZZZZZZZZ9"), 91, Gx_line+117, 160, Gx_line+132, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 612, Gx_line+26, 663, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV20Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 87, Gx_line+52, 614, Gx_line+67, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 617, Gx_line+0, 672, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 617, Gx_line+13, 672, Gx_line+28, 0+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("De", 39, Gx_line+91, 55, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("até", 142, Gx_line+91, 160, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("Seleção", 39, Gx_line+117, 85, Gx_line+130, 0+256) ;
               getPrinter().GxDrawText("Categoria", 39, Gx_line+182, 93, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("Data:", 573, Gx_line+0, 604, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 573, Gx_line+13, 604, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 560, Gx_line+26, 603, Gx_line+39, 0+256) ;
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
         GXAsk ask = new GXAsk( "Relatório de topo de lista sobre total de cancelamentos por categoria." , true , new GXAskObject[] {
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
         AV13AuxLoc = 0 ;
         AV14Catego = new GxObjectCollection( context, "SDTCatRelatorio.SDTCatDevolucaoItem", "AgoraVaiCurso", "SdtSDTCatRelatorio_SDTCatDevolucaoItem", "GeneXus.Programs");
         scmdbuf = "" ;
         R000V2_A102LocMid = new int[1] ;
         R000V2_A86LocCodi = new int[1] ;
         R000V2_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         R000V2_n90LocDatC = new bool[] {false} ;
         R000V2_A105LocMid = new int[1] ;
         R000V2_n105LocMid = new bool[] {false} ;
         R000V2_A118LocMid = new String[] {""} ;
         R000V2_n118LocMid = new bool[] {false} ;
         BRK0V3 = false ;
         A86LocCodi = 0 ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         A105LocMid = 0 ;
         n105LocMid = false ;
         A118LocMid = "" ;
         n118LocMid = false ;
         AV15Item = new SdtSDTCatRelatorio_SDTCatDevolucaoItem(context);
         AV16ContSe = 0 ;
         AV25GXV1 = 0 ;
         AV11CatNom = "" ;
         Gx_OldLine = 0 ;
         AV12TotDev = 0 ;
         AV20Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rreltopdeliscanporcategoria__default(),
            new Object[][] {
                new Object[] {
               R000V2_A102LocMid, R000V2_A86LocCodi, R000V2_A90LocDatC, R000V2_n90LocDatC, R000V2_A105LocMid, R000V2_n105LocMid, R000V2_A118LocMid, R000V2_n118LocMid
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV20Pgmdes = "Relatório de topo de lista sobre total de cancelamentos por categoria." ;
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
      private int AV13AuxLoc ;
      private int A86LocCodi ;
      private int A105LocMid ;
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
      private bool BRK0V3 ;
      private bool n90LocDatC ;
      private bool n105LocMid ;
      private bool n118LocMid ;
      private String A118LocMid ;
      private String AV11CatNom ;
      private IGxDataStore dsDefault ;
      private IDataReader R000V2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000V2_A102LocMid ;
      private int[] R000V2_A86LocCodi ;
      private DateTime[] R000V2_A90LocDatC ;
      private bool[] R000V2_n90LocDatC ;
      private int[] R000V2_A105LocMid ;
      private bool[] R000V2_n105LocMid ;
      private String[] R000V2_A118LocMid ;
      private bool[] R000V2_n118LocMid ;
      private GxObjectCollection AV14Catego ;
      private SdtSDTCatRelatorio_SDTCatDevolucaoItem AV15Item ;
   }

   public class rreltopdeliscanporcategoria__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmR000V2 ;
          prmR000V2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000V2", "SELECT T1.[LocMidMidCodigo], T1.[LocCodigo], T2.[LocDatCancelamento], T1.[LocMidCatCodigo] AS LocMidCatCodigo, T3.[CatNome] AS LocMidCatNome FROM (([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) INNER JOIN [LOCACAO] T2 WITH (NOLOCK) ON T2.[LocCodigo] = T1.[LocCodigo]) LEFT JOIN [CATEGORIA] T3 WITH (NOLOCK) ON T3.[CatCodigo] = T1.[LocMidCatCodigo]) ORDER BY T1.[LocMidCatCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000V2,100,0,true,false )
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
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
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
