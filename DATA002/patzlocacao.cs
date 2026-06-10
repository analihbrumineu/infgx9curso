/*
               File: AtzLocacao
        Description: Atualizar locação
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 8:22:46.14
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
   public class patzlocacao_wrapper : GXJWin
   {
      public patzlocacao_wrapper( int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class patzlocacao : GXWinProcedure
   {
      public patzlocacao( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public patzlocacao( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public patzlocacao( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public patzlocacao( IGxContext context ,
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

      public void execute( short aP0_Y ,
                           ref int aP1_LocCodigo ,
                           short aP2_AtzLocacao ,
                           ref short aP3_LocSituacao ,
                           out String aP4_MsgErro )
      {
         this.AV14Y = aP0_Y;
         this.AV9LocCodi = aP1_LocCodigo;
         this.AV8AtzLoca = aP2_AtzLocacao;
         this.AV11LocSit = aP3_LocSituacao;
         this.AV19MsgErr = "" ;
         initialize();
         executePrivate();
         aP1_LocCodigo=this.AV9LocCodi;
         aP3_LocSituacao=this.AV11LocSit;
         aP4_MsgErro=this.AV19MsgErr;
      }

      public void executeSubmit( short aP0_Y ,
                                 ref int aP1_LocCodigo ,
                                 short aP2_AtzLocacao ,
                                 ref short aP3_LocSituacao ,
                                 out String aP4_MsgErro )
      {
         patzlocacao objpatzlocacao;
         objpatzlocacao = new patzlocacao();
         objpatzlocacao.AV14Y = aP0_Y;
         objpatzlocacao.AV9LocCodi = aP1_LocCodigo;
         objpatzlocacao.AV8AtzLoca = aP2_AtzLocacao;
         objpatzlocacao.AV11LocSit = aP3_LocSituacao;
         objpatzlocacao.AV19MsgErr = "" ;
         objpatzlocacao.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpatzlocacao.executePrivateCatch ));
         aP1_LocCodigo=this.AV9LocCodi;
         aP3_LocSituacao=this.AV11LocSit;
         aP4_MsgErro=this.AV19MsgErr;
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
         if ( ( AV14Y == 1 ) )
         {
            /* Using cursor P000H2 */
            pr_default.execute(0, new Object[] {AV9LocCodi, AV11LocSit});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A86LocCodi = P000H2_A86LocCodi[0] ;
               A87LocSitu = P000H2_A87LocSitu[0] ;
               n87LocSitu = P000H2_n87LocSitu[0] ;
               if ( ( A87LocSitu == AV11LocSit ) )
               {
                  A87LocSitu = 2 ;
                  n87LocSitu = false ;
                  /* Using cursor P000H3 */
                  pr_default.execute(1, new Object[] {A86LocCodi});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A103LocMid = P000H3_A103LocMid[0] ;
                     n103LocMid = P000H3_n103LocMid[0] ;
                     A107LocMid = P000H3_A107LocMid[0] ;
                     n107LocMid = P000H3_n107LocMid[0] ;
                     A108LocMid = P000H3_A108LocMid[0] ;
                     n108LocMid = P000H3_n108LocMid[0] ;
                     A102LocMid = P000H3_A102LocMid[0] ;
                     A107LocMid = P000H3_A107LocMid[0] ;
                     n107LocMid = P000H3_n107LocMid[0] ;
                     if ( ( A107LocMid != 2 ) )
                     {
                        A107LocMid = 2 ;
                        n107LocMid = false ;
                        A108LocMid = AV9LocCodi ;
                        n108LocMid = false ;
                        AV15LocCod = A86LocCodi ;
                        AV13LocMid = A102LocMid ;
                        /* Execute user subroutine: S11108 */
                        S11108 ();
                        if ( returnInSub )
                        {
                           pr_default.close(1);
                           this.cleanup();
                           if (true) return;
                        }
                     }
                     /* Using cursor P000H4 */
                     pr_default.execute(2, new Object[] {n107LocMid, A107LocMid, A102LocMid});
                     pr_default.close(2);
                     /* Using cursor P000H5 */
                     pr_default.execute(3, new Object[] {n108LocMid, A108LocMid, A86LocCodi, A102LocMid});
                     pr_default.close(3);
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  /* Using cursor P000H6 */
                  pr_default.execute(4, new Object[] {n87LocSitu, A87LocSitu, A86LocCodi});
                  pr_default.close(4);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         if ( ( AV8AtzLoca == 1 ) )
         {
            /* Using cursor P000H7 */
            pr_default.execute(5, new Object[] {AV9LocCodi, AV11LocSit});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A86LocCodi = P000H7_A86LocCodi[0] ;
               A87LocSitu = P000H7_A87LocSitu[0] ;
               n87LocSitu = P000H7_n87LocSitu[0] ;
               A89LocDatD = P000H7_A89LocDatD[0] ;
               n89LocDatD = P000H7_n89LocDatD[0] ;
               if ( ( A87LocSitu == AV11LocSit ) )
               {
                  if ( ( A87LocSitu == 1 ) )
                  {
                     new ppevalmidias(context, remoteHandle, jContext ).execute(  A86LocCodi, out  AV19MsgErr) ;
                     if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV19MsgErr).TrimEnd(' ') )==0)) )
                     {
                        /* Using cursor P000H8 */
                        pr_default.execute(6, new Object[] {A86LocCodi});
                        while ( (pr_default.getStatus(6) != 101) )
                        {
                           A103LocMid = P000H8_A103LocMid[0] ;
                           n103LocMid = P000H8_n103LocMid[0] ;
                           A107LocMid = P000H8_A107LocMid[0] ;
                           n107LocMid = P000H8_n107LocMid[0] ;
                           A108LocMid = P000H8_A108LocMid[0] ;
                           n108LocMid = P000H8_n108LocMid[0] ;
                           A102LocMid = P000H8_A102LocMid[0] ;
                           A107LocMid = P000H8_A107LocMid[0] ;
                           n107LocMid = P000H8_n107LocMid[0] ;
                           A107LocMid = 2 ;
                           n107LocMid = false ;
                           A108LocMid = AV9LocCodi ;
                           n108LocMid = false ;
                           AV13LocMid = A102LocMid ;
                           AV15LocCod = A86LocCodi ;
                           /* Execute user subroutine: S11108 */
                           S11108 ();
                           if ( returnInSub )
                           {
                              pr_default.close(6);
                              this.cleanup();
                              if (true) return;
                           }
                           /* Using cursor P000H9 */
                           pr_default.execute(7, new Object[] {n107LocMid, A107LocMid, A102LocMid});
                           pr_default.close(7);
                           /* Using cursor P000H10 */
                           pr_default.execute(8, new Object[] {n108LocMid, A108LocMid, A86LocCodi, A102LocMid});
                           pr_default.close(8);
                           pr_default.readNext(6);
                        }
                        pr_default.close(6);
                        A87LocSitu = 2 ;
                        n87LocSitu = false ;
                     }
                  }
                  else
                  {
                     if ( ( A87LocSitu == 2 ) )
                     {
                        A87LocSitu = 3 ;
                        n87LocSitu = false ;
                        A89LocDatD = Gx_date ;
                        n89LocDatD = false ;
                        /* Using cursor P000H11 */
                        pr_default.execute(9, new Object[] {A86LocCodi});
                        while ( (pr_default.getStatus(9) != 101) )
                        {
                           A103LocMid = P000H11_A103LocMid[0] ;
                           n103LocMid = P000H11_n103LocMid[0] ;
                           A107LocMid = P000H11_A107LocMid[0] ;
                           n107LocMid = P000H11_n107LocMid[0] ;
                           A108LocMid = P000H11_A108LocMid[0] ;
                           n108LocMid = P000H11_n108LocMid[0] ;
                           A102LocMid = P000H11_A102LocMid[0] ;
                           A107LocMid = P000H11_A107LocMid[0] ;
                           n107LocMid = P000H11_n107LocMid[0] ;
                           A107LocMid = 1 ;
                           n107LocMid = false ;
                           A108LocMid = 0 ;
                           n108LocMid = false ;
                           AV13LocMid = A102LocMid ;
                           AV15LocCod = A86LocCodi ;
                           /* Execute user subroutine: S12119 */
                           S12119 ();
                           if ( returnInSub )
                           {
                              pr_default.close(9);
                              this.cleanup();
                              if (true) return;
                           }
                           /* Using cursor P000H12 */
                           pr_default.execute(10, new Object[] {n107LocMid, A107LocMid, A102LocMid});
                           pr_default.close(10);
                           /* Using cursor P000H13 */
                           pr_default.execute(11, new Object[] {n108LocMid, A108LocMid, A86LocCodi, A102LocMid});
                           pr_default.close(11);
                           pr_default.readNext(9);
                        }
                        pr_default.close(9);
                     }
                  }
                  /* Using cursor P000H14 */
                  pr_default.execute(12, new Object[] {n87LocSitu, A87LocSitu, n89LocDatD, A89LocDatD, A86LocCodi});
                  pr_default.close(12);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(5);
         }
         if ( ( AV8AtzLoca == 2 ) )
         {
            /* Using cursor P000H15 */
            pr_default.execute(13, new Object[] {AV9LocCodi, AV11LocSit});
            while ( (pr_default.getStatus(13) != 101) )
            {
               A86LocCodi = P000H15_A86LocCodi[0] ;
               A87LocSitu = P000H15_A87LocSitu[0] ;
               n87LocSitu = P000H15_n87LocSitu[0] ;
               A90LocDatC = P000H15_A90LocDatC[0] ;
               n90LocDatC = P000H15_n90LocDatC[0] ;
               if ( ( A87LocSitu == AV11LocSit ) )
               {
                  if ( ( A87LocSitu == 1 ) )
                  {
                     /* Optimized DELETE. */
                     /* Using cursor P000H16 */
                     pr_default.execute(14, new Object[] {A86LocCodi});
                     pr_default.close(14);
                     /* End optimized DELETE. */
                     /* Using cursor P000H17 */
                     pr_default.execute(15, new Object[] {A86LocCodi});
                     pr_default.close(15);
                  }
                  else
                  {
                     if ( ( A87LocSitu == 2 ) )
                     {
                        A87LocSitu = 4 ;
                        n87LocSitu = false ;
                        A90LocDatC = Gx_date ;
                        n90LocDatC = false ;
                        /* Using cursor P000H18 */
                        pr_default.execute(16, new Object[] {A86LocCodi});
                        while ( (pr_default.getStatus(16) != 101) )
                        {
                           A103LocMid = P000H18_A103LocMid[0] ;
                           n103LocMid = P000H18_n103LocMid[0] ;
                           A107LocMid = P000H18_A107LocMid[0] ;
                           n107LocMid = P000H18_n107LocMid[0] ;
                           A108LocMid = P000H18_A108LocMid[0] ;
                           n108LocMid = P000H18_n108LocMid[0] ;
                           A102LocMid = P000H18_A102LocMid[0] ;
                           A107LocMid = P000H18_A107LocMid[0] ;
                           n107LocMid = P000H18_n107LocMid[0] ;
                           A107LocMid = 1 ;
                           n107LocMid = false ;
                           A108LocMid = 0 ;
                           n108LocMid = false ;
                           AV15LocCod = A86LocCodi ;
                           AV13LocMid = A102LocMid ;
                           /* Execute user subroutine: S12119 */
                           S12119 ();
                           if ( returnInSub )
                           {
                              pr_default.close(16);
                              this.cleanup();
                              if (true) return;
                           }
                           /* Using cursor P000H19 */
                           pr_default.execute(17, new Object[] {n107LocMid, A107LocMid, A102LocMid});
                           pr_default.close(17);
                           /* Using cursor P000H20 */
                           pr_default.execute(18, new Object[] {n108LocMid, A108LocMid, A86LocCodi, A102LocMid});
                           pr_default.close(18);
                           pr_default.readNext(16);
                        }
                        pr_default.close(16);
                     }
                  }
                  /* Using cursor P000H21 */
                  pr_default.execute(19, new Object[] {n87LocSitu, A87LocSitu, n90LocDatC, A90LocDatC, A86LocCodi});
                  pr_default.close(19);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(13);
         }
         this.cleanup();
      }

      protected void S11108( )
      {
         /* 'LOCARMIDIA' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P000H22 */
         pr_default.execute(20, new Object[] {n116LocCod, AV15LocCod, AV13LocMid});
         pr_default.close(20);
         /* End optimized UPDATE. */
         context.CommitDataStores("PAtzLocacao");
      }

      protected void S12119( )
      {
         /* 'LIBERARMIDIA' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P000H23 */
         pr_default.execute(21, new Object[] {AV13LocMid});
         pr_default.close(21);
         /* End optimized UPDATE. */
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV9LocCodi = AV9LocCodi;
         this.AV11LocSit = AV11LocSit;
         this.AV19MsgErr = AV19MsgErr;
         context.CommitDataStores("PAtzLocacao");
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
         scmdbuf = "" ;
         P000H2_A86LocCodi = new int[1] ;
         P000H2_A87LocSitu = new short[1] ;
         P000H2_n87LocSitu = new bool[] {false} ;
         A86LocCodi = 0 ;
         A87LocSitu = 0 ;
         n87LocSitu = false ;
         P000H3_A86LocCodi = new int[1] ;
         P000H3_A103LocMid = new int[1] ;
         P000H3_n103LocMid = new bool[] {false} ;
         P000H3_A107LocMid = new short[1] ;
         P000H3_n107LocMid = new bool[] {false} ;
         P000H3_A108LocMid = new int[1] ;
         P000H3_n108LocMid = new bool[] {false} ;
         P000H3_A102LocMid = new int[1] ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         A107LocMid = 0 ;
         n107LocMid = false ;
         A108LocMid = 0 ;
         n108LocMid = false ;
         A102LocMid = 0 ;
         AV15LocCod = 0 ;
         AV13LocMid = 0 ;
         returnInSub = false ;
         P000H7_A86LocCodi = new int[1] ;
         P000H7_A87LocSitu = new short[1] ;
         P000H7_n87LocSitu = new bool[] {false} ;
         P000H7_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         P000H7_n89LocDatD = new bool[] {false} ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         P000H8_A86LocCodi = new int[1] ;
         P000H8_A103LocMid = new int[1] ;
         P000H8_n103LocMid = new bool[] {false} ;
         P000H8_A107LocMid = new short[1] ;
         P000H8_n107LocMid = new bool[] {false} ;
         P000H8_A108LocMid = new int[1] ;
         P000H8_n108LocMid = new bool[] {false} ;
         P000H8_A102LocMid = new int[1] ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         P000H11_A86LocCodi = new int[1] ;
         P000H11_A103LocMid = new int[1] ;
         P000H11_n103LocMid = new bool[] {false} ;
         P000H11_A107LocMid = new short[1] ;
         P000H11_n107LocMid = new bool[] {false} ;
         P000H11_A108LocMid = new int[1] ;
         P000H11_n108LocMid = new bool[] {false} ;
         P000H11_A102LocMid = new int[1] ;
         P000H15_A86LocCodi = new int[1] ;
         P000H15_A87LocSitu = new short[1] ;
         P000H15_n87LocSitu = new bool[] {false} ;
         P000H15_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         P000H15_n90LocDatC = new bool[] {false} ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         P000H18_A86LocCodi = new int[1] ;
         P000H18_A103LocMid = new int[1] ;
         P000H18_n103LocMid = new bool[] {false} ;
         P000H18_A107LocMid = new short[1] ;
         P000H18_n107LocMid = new bool[] {false} ;
         P000H18_A108LocMid = new int[1] ;
         P000H18_n108LocMid = new bool[] {false} ;
         P000H18_A102LocMid = new int[1] ;
         n116LocCod = false ;
         A116LocCod = 0 ;
         Gx_date = DateTimeUtil.Today( ) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.patzlocacao__default(),
            new Object[][] {
                new Object[] {
               P000H2_A86LocCodi, P000H2_A87LocSitu, P000H2_n87LocSitu
               }
               , new Object[] {
               P000H3_A86LocCodi, P000H3_A103LocMid, P000H3_n103LocMid, P000H3_A107LocMid, P000H3_n107LocMid, P000H3_A108LocMid, P000H3_n108LocMid, P000H3_A102LocMid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P000H7_A86LocCodi, P000H7_A87LocSitu, P000H7_n87LocSitu, P000H7_A89LocDatD, P000H7_n89LocDatD
               }
               , new Object[] {
               P000H8_A86LocCodi, P000H8_A103LocMid, P000H8_n103LocMid, P000H8_A107LocMid, P000H8_n107LocMid, P000H8_A108LocMid, P000H8_n108LocMid, P000H8_A102LocMid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P000H11_A86LocCodi, P000H11_A103LocMid, P000H11_n103LocMid, P000H11_A107LocMid, P000H11_n107LocMid, P000H11_A108LocMid, P000H11_n108LocMid, P000H11_A102LocMid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P000H15_A86LocCodi, P000H15_A87LocSitu, P000H15_n87LocSitu, P000H15_A90LocDatC, P000H15_n90LocDatC
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P000H18_A86LocCodi, P000H18_A103LocMid, P000H18_n103LocMid, P000H18_A107LocMid, P000H18_n107LocMid, P000H18_A108LocMid, P000H18_n108LocMid, P000H18_A102LocMid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV14Y ;
      private short AV8AtzLoca ;
      private short AV11LocSit ;
      private short A87LocSitu ;
      private short A107LocMid ;
      private int AV9LocCodi ;
      private int A86LocCodi ;
      private int A103LocMid ;
      private int A108LocMid ;
      private int A102LocMid ;
      private int AV15LocCod ;
      private int AV13LocMid ;
      private int A116LocCod ;
      private String scmdbuf ;
      private DateTime A89LocDatD ;
      private DateTime Gx_date ;
      private DateTime A90LocDatC ;
      private bool n87LocSitu ;
      private bool n103LocMid ;
      private bool n107LocMid ;
      private bool n108LocMid ;
      private bool returnInSub ;
      private bool n89LocDatD ;
      private bool n90LocDatC ;
      private bool n116LocCod ;
      private String AV19MsgErr ;
      private IGxDataStore dsDefault ;
      private int aP1_LocCodigo ;
      private short aP3_LocSituacao ;
      private IDataReader P000H2 ;
      private IDataStoreProvider pr_default ;
      private int[] P000H2_A86LocCodi ;
      private short[] P000H2_A87LocSitu ;
      private bool[] P000H2_n87LocSitu ;
      private IDataReader P000H3 ;
      private int[] P000H3_A86LocCodi ;
      private int[] P000H3_A103LocMid ;
      private bool[] P000H3_n103LocMid ;
      private short[] P000H3_A107LocMid ;
      private bool[] P000H3_n107LocMid ;
      private int[] P000H3_A108LocMid ;
      private bool[] P000H3_n108LocMid ;
      private int[] P000H3_A102LocMid ;
      private IDataReader P000H7 ;
      private int[] P000H7_A86LocCodi ;
      private short[] P000H7_A87LocSitu ;
      private bool[] P000H7_n87LocSitu ;
      private DateTime[] P000H7_A89LocDatD ;
      private bool[] P000H7_n89LocDatD ;
      private IDataReader P000H8 ;
      private int[] P000H8_A86LocCodi ;
      private int[] P000H8_A103LocMid ;
      private bool[] P000H8_n103LocMid ;
      private short[] P000H8_A107LocMid ;
      private bool[] P000H8_n107LocMid ;
      private int[] P000H8_A108LocMid ;
      private bool[] P000H8_n108LocMid ;
      private int[] P000H8_A102LocMid ;
      private IDataReader P000H11 ;
      private int[] P000H11_A86LocCodi ;
      private int[] P000H11_A103LocMid ;
      private bool[] P000H11_n103LocMid ;
      private short[] P000H11_A107LocMid ;
      private bool[] P000H11_n107LocMid ;
      private int[] P000H11_A108LocMid ;
      private bool[] P000H11_n108LocMid ;
      private int[] P000H11_A102LocMid ;
      private IDataReader P000H15 ;
      private int[] P000H15_A86LocCodi ;
      private short[] P000H15_A87LocSitu ;
      private bool[] P000H15_n87LocSitu ;
      private DateTime[] P000H15_A90LocDatC ;
      private bool[] P000H15_n90LocDatC ;
      private IDataReader P000H18 ;
      private int[] P000H18_A86LocCodi ;
      private int[] P000H18_A103LocMid ;
      private bool[] P000H18_n103LocMid ;
      private short[] P000H18_A107LocMid ;
      private bool[] P000H18_n107LocMid ;
      private int[] P000H18_A108LocMid ;
      private bool[] P000H18_n108LocMid ;
      private int[] P000H18_A102LocMid ;
      private String aP4_MsgErro ;
   }

   public class patzlocacao__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[4])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[5])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[16])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[17])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[18])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[19])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[20])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmP000H2 ;
          prmP000H2 = new Object[] {
          new Object[] {"@AV9LocCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11LocSit",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP000H3 ;
          prmP000H3 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H4 ;
          prmP000H4 = new Object[] {
          new Object[] {"@LocMidMidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H5 ;
          prmP000H5 = new Object[] {
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H6 ;
          prmP000H6 = new Object[] {
          new Object[] {"@LocSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H7 ;
          prmP000H7 = new Object[] {
          new Object[] {"@AV9LocCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11LocSit",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP000H8 ;
          prmP000H8 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H9 ;
          prmP000H9 = new Object[] {
          new Object[] {"@LocMidMidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H10 ;
          prmP000H10 = new Object[] {
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H11 ;
          prmP000H11 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H12 ;
          prmP000H12 = new Object[] {
          new Object[] {"@LocMidMidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H13 ;
          prmP000H13 = new Object[] {
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H14 ;
          prmP000H14 = new Object[] {
          new Object[] {"@LocSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocDatDevolucao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H15 ;
          prmP000H15 = new Object[] {
          new Object[] {"@AV9LocCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11LocSit",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP000H16 ;
          prmP000H16 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H17 ;
          prmP000H17 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H18 ;
          prmP000H18 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H19 ;
          prmP000H19 = new Object[] {
          new Object[] {"@LocMidMidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H20 ;
          prmP000H20 = new Object[] {
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H21 ;
          prmP000H21 = new Object[] {
          new Object[] {"@LocSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocDatCancelamento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H22 ;
          prmP000H22 = new Object[] {
          new Object[] {"@LocCodLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV13LocMid",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H23 ;
          prmP000H23 = new Object[] {
          new Object[] {"@AV13LocMid",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000H2", "SELECT [LocCodigo], [LocSituacao] FROM [LOCACAO] WITH (UPDLOCK) WHERE ([LocCodigo] = @AV9LocCodi) AND (([LocCodigo] = @AV9LocCodi) AND ([LocSituacao] = @AV11LocSit)) ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H2,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H3", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T2.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidMidLocCodigo], T1.[LocMidMidCodigo] AS LocMidMidCodigo FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (UPDLOCK) INNER JOIN [MIDIA] T2 WITH (UPDLOCK) ON T2.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @LocCodigo ORDER BY T1.[LocCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H3,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H4", "UPDATE [MIDIA] SET [MidSituacao]=@LocMidMidSituacao  WHERE [MidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H4)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H5", "UPDATE [LOCACAOLOCACAOMIDIA] SET [LocMidMidLocCodigo]=@LocMidMidLocCodigo  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H5)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H6", "UPDATE [LOCACAO] SET [LocSituacao]=@LocSituacao  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H6)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H7", "SELECT [LocCodigo], [LocSituacao], [LocDatDevolucao] FROM [LOCACAO] WITH (UPDLOCK) WHERE ([LocCodigo] = @AV9LocCodi) AND (([LocCodigo] = @AV9LocCodi) AND ([LocSituacao] = @AV11LocSit)) ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H7,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H8", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T2.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidMidLocCodigo], T1.[LocMidMidCodigo] AS LocMidMidCodigo FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (UPDLOCK) INNER JOIN [MIDIA] T2 WITH (UPDLOCK) ON T2.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @LocCodigo ORDER BY T1.[LocCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H8,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H9", "UPDATE [MIDIA] SET [MidSituacao]=@LocMidMidSituacao  WHERE [MidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H9)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H10", "UPDATE [LOCACAOLOCACAOMIDIA] SET [LocMidMidLocCodigo]=@LocMidMidLocCodigo  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H10)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H11", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T2.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidMidLocCodigo], T1.[LocMidMidCodigo] AS LocMidMidCodigo FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (UPDLOCK) INNER JOIN [MIDIA] T2 WITH (UPDLOCK) ON T2.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @LocCodigo ORDER BY T1.[LocCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H11,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H12", "UPDATE [MIDIA] SET [MidSituacao]=@LocMidMidSituacao  WHERE [MidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H12)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H13", "UPDATE [LOCACAOLOCACAOMIDIA] SET [LocMidMidLocCodigo]=@LocMidMidLocCodigo  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H13)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H14", "UPDATE [LOCACAO] SET [LocSituacao]=@LocSituacao, [LocDatDevolucao]=@LocDatDevolucao  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H14)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H15", "SELECT [LocCodigo], [LocSituacao], [LocDatCancelamento] FROM [LOCACAO] WITH (UPDLOCK) WHERE ([LocCodigo] = @AV9LocCodi) AND (([LocCodigo] = @AV9LocCodi) AND ([LocSituacao] = @AV11LocSit)) ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H15,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H16", "DELETE FROM [LOCACAOLOCACAOMIDIA]  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H16)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H17", "DELETE FROM [LOCACAO]  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H17)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H18", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T2.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidMidLocCodigo], T1.[LocMidMidCodigo] AS LocMidMidCodigo FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (UPDLOCK) INNER JOIN [MIDIA] T2 WITH (UPDLOCK) ON T2.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @LocCodigo ORDER BY T1.[LocCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H18,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H19", "UPDATE [MIDIA] SET [MidSituacao]=@LocMidMidSituacao  WHERE [MidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H19)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H20", "UPDATE [LOCACAOLOCACAOMIDIA] SET [LocMidMidLocCodigo]=@LocMidMidLocCodigo  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H20)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H21", "UPDATE [LOCACAO] SET [LocSituacao]=@LocSituacao, [LocDatCancelamento]=@LocDatCancelamento  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H21)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H22", "UPDATE [MIDIA] SET [MidSituacao]=2, [LocCodLocCodigo]=@LocCodLocCodigo  WHERE [MidCodigo] = @AV13LocMid", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H22)
             ,new GeneXus.Data.NTier.ADO.CursorDef("P000H23", "UPDATE [MIDIA] SET [MidSituacao]=1, [LocCodLocCodigo]=0  WHERE [MidCodigo] = @AV13LocMid", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000H23)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                stmt.SetParameter(3, (int)parms[4]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 18 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                break;
             case 19 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                stmt.SetParameter(3, (int)parms[4]);
                break;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
