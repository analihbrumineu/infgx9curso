/*
               File: ConsMidia
        Description: Consulta de mídias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:11.60
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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wconsmidia : GXWorkpanel
   {
      public wconsmidia( int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconsmidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconsmidia( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsMidia" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de mídias." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 858 ;
      }

      public override int getFrmHeight( )
      {
         return 832 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsMidia.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( out int aP0_MidCodRetornado ,
                           out int aP1_FilCodRetornado ,
                           out String aP2_FilNomRetornado ,
                           out int aP3_CatCodRetornado ,
                           out short aP4_MidTipRetornado ,
                           out decimal aP5_LocMidValRetornado )
      {
         this.AV32MidCod = 0 ;
         this.AV41FilCod = 0 ;
         this.AV36FilNom = "" ;
         this.AV43CatCod = 0 ;
         this.AV34MidTip = 0 ;
         this.AV35LocMid = 0M ;
         executePrivate();
         aP0_MidCodRetornado=this.AV32MidCod;
         aP1_FilCodRetornado=this.AV41FilCod;
         aP2_FilNomRetornado=this.AV36FilNom;
         aP3_CatCodRetornado=this.AV43CatCod;
         aP4_MidTipRetornado=this.AV34MidTip;
         aP5_LocMidValRetornado=this.AV35LocMid;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load08( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconsmidia08 = new subwconsmidia08 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV6MidCodi ,
                                              AV5FilNome ,
                                              AV8MidTipo ,
                                              AV44FilDat ,
                                              AV45CatNom ,
                                              A37MidCodi ,
                                              A29FilNome ,
                                              A35MidTipo ,
                                              A31FilData ,
                                              A33CatNome ,
                                              A85ConfTip ,
                                              A36MidSitu },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                              TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000N2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf8.getSize() < 10000 ) ) )
         {
            A32CatCodi = W000N2_A32CatCodi[0] ;
            n32CatCodi = W000N2_n32CatCodi[0] ;
            A85ConfTip = W000N2_A85ConfTip[0] ;
            n85ConfTip = W000N2_n85ConfTip[0] ;
            A36MidSitu = W000N2_A36MidSitu[0] ;
            n36MidSitu = W000N2_n36MidSitu[0] ;
            A35MidTipo = W000N2_A35MidTipo[0] ;
            n35MidTipo = W000N2_n35MidTipo[0] ;
            A31FilData = W000N2_A31FilData[0] ;
            n31FilData = W000N2_n31FilData[0] ;
            A33CatNome = W000N2_A33CatNome[0] ;
            n33CatNome = W000N2_n33CatNome[0] ;
            A29FilNome = W000N2_A29FilNome[0] ;
            n29FilNome = W000N2_n29FilNome[0] ;
            A28FilCodi = W000N2_A28FilCodi[0] ;
            n28FilCodi = W000N2_n28FilCodi[0] ;
            A37MidCodi = W000N2_A37MidCodi[0] ;
            A32CatCodi = W000N2_A32CatCodi[0] ;
            n32CatCodi = W000N2_n32CatCodi[0] ;
            A31FilData = W000N2_A31FilData[0] ;
            n31FilData = W000N2_n31FilData[0] ;
            A29FilNome = W000N2_A29FilNome[0] ;
            n29FilNome = W000N2_n29FilNome[0] ;
            A33CatNome = W000N2_A33CatNome[0] ;
            n33CatNome = W000N2_n33CatNome[0] ;
            A85ConfTip = W000N2_A85ConfTip[0] ;
            n85ConfTip = W000N2_n85ConfTip[0] ;
            /* Execute user event: E11V0N2 */
            E11V0N2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf8.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsMidia_load08 : GXLoadProducer
      {
         wconsmidia _sf ;

         public ConsMidia_load08( wconsmidia uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer08();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load08();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors08();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGxsf8.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow08( )
      {
         return true;
      }

      public void autoRefresh_flow08( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow08() )) {
            subfile.refresh();
            resetSubfileConditions_flow08() ;
         }
      }

      public bool getSearch_flow08( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow08( )
      {
      }

      public void resetSearchConditions_flow08( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow08( )
      {
         return new subwconsmidia08 ();
      }

      public bool getSearch_flow08( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow08( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow08( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow08( )
      {
         GXRefreshCommand08 ();
      }

      public class ConsMidia_flow08 : GXSubfileFlow
      {
         wconsmidia _sf ;

         public ConsMidia_flow08( wconsmidia uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow08();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow08(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow08();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow08();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow08(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow08();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow08(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow08(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow08(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow08();
         }

      }

      protected void GXRefreshCommand08( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E12V0N2 */
         E12V0N2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V0N2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         chkavFilatoprot.setEnabled(0);
      }

      public override void GXExit( )
      {
         /* Execute user event: E13V0N2 */
         E13V0N2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E13V0N2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV32MidCod = A37MidCodi ;
         AV41FilCod = A28FilCodi ;
         AV36FilNom = A29FilNome ;
         AV34MidTip = A35MidTipo ;
         /* Using cursor W000N3 */
         pr_default.execute(1, new Object[] {AV41FilCod});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A28FilCodi = W000N3_A28FilCodi[0] ;
            n28FilCodi = W000N3_n28FilCodi[0] ;
            A32CatCodi = W000N3_A32CatCodi[0] ;
            n32CatCodi = W000N3_n32CatCodi[0] ;
            AV43CatCod = A32CatCodi ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         /* Using cursor W000N4 */
         pr_default.execute(2, new Object[] {AV34MidTip, AV43CatCod});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A32CatCodi = W000N4_A32CatCodi[0] ;
            n32CatCodi = W000N4_n32CatCodi[0] ;
            A35MidTipo = W000N4_A35MidTipo[0] ;
            n35MidTipo = W000N4_n35MidTipo[0] ;
            A85ConfTip = W000N4_A85ConfTip[0] ;
            n85ConfTip = W000N4_n85ConfTip[0] ;
            AV35LocMid = A85ConfTip ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void E14V0N2( )
      {
         eventLevelContext();
         /* MidCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E15V0N2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("AV13FilAto") )
         {
            new wconsastro(context, base.remoteHandle, base.context).execute( out  AV13FilAto) ;
            ((subwconsmidia08)subGxsf8.getCurrentElement()).setVFilAtoCodigo(AV13FilAto);
            subGxsf8.refreshLineValue(subGxsf8.getSelectedElement());
            subGxsf8.repaint();
         }
         else if ( GXCursor("AV17FilDir") )
         {
            new wconsastro(context, base.remoteHandle, base.context).execute( out  AV17FilDir) ;
            ((subwconsmidia08)subGxsf8.getCurrentElement()).setVFilDirCodigo(AV17FilDir);
            subGxsf8.refreshLineValue(subGxsf8.getSelectedElement());
            subGxsf8.repaint();
         }
         eventLevelResetContext();
      }

      protected void E16V0N2( )
      {
         eventLevelContext();
         /* Filatocodigo_Isvalid Routine */
         if ( ( AV13FilAto > 0 ) )
         {
            chkavFilatoprot.setEnabled(1);
         }
         eventLevelResetContext();
      }

      public void loadToBuffer08( )
      {
         subwconsmidia08 oAux = subwconsmidia08 ;
         subwconsmidia08 = new subwconsmidia08 ();
         variablesToSubfile08 ();
         subGxsf8.addElement(subwconsmidia08);
         subwconsmidia08 = oAux;
      }

      private void E11V0N2( )
      {
         AV13FilAto = 0 ;
         AV14FilAto = "" ;
         AV17FilDir = 0 ;
         AV18FilDir = "" ;
         /* Load Routine */
         AV15FilCod = A28FilCodi ;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV13FilAto ,
                                              AV12FilAto ,
                                              AV14FilAto ,
                                              A77FilAtoC ,
                                              A81FilAtoP ,
                                              AV19FilAto ,
                                              A28FilCodi },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         /* Using cursor W000N5 */
         pr_default.execute(3, new Object[] {AV19FilAto});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A28FilCodi = W000N5_A28FilCodi[0] ;
            n28FilCodi = W000N5_n28FilCodi[0] ;
            A81FilAtoP = W000N5_A81FilAtoP[0] ;
            n81FilAtoP = W000N5_n81FilAtoP[0] ;
            A77FilAtoC = W000N5_A77FilAtoC[0] ;
            pr_default.dynParam(4, new Object[]{ new Object[]{
                                                 AV17FilDir ,
                                                 AV18FilDir ,
                                                 A79FilDirC ,
                                                 A80FilDirN ,
                                                 A28FilCodi },
                                                 new int[] {
                                                 TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            /* Using cursor W000N6 */
            pr_default.execute(4, new Object[] {n28FilCodi, A28FilCodi});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A80FilDirN = W000N6_A80FilDirN[0] ;
               n80FilDirN = W000N6_n80FilDirN[0] ;
               A79FilDirC = W000N6_A79FilDirC[0] ;
               A80FilDirN = W000N6_A80FilDirN[0] ;
               n80FilDirN = W000N6_n80FilDirN[0] ;
               pr_default.readNext(4);
            }
            pr_default.close(4);
            pr_default.readNext(3);
         }
         pr_default.close(3);
         subGxsf8.loadCommand();
      }

      protected void closeCursors08( )
      {
         pr_default.close(0);
         pr_default.close(4);
         pr_default.close(3);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 858 , 832 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavAstcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 0 , 0 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10AstCod" );
         ((GXEdit) edtavAstcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavAstcodigo.addFocusListener(this);
         edtavAstcodigo.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavMidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),52, 78, 104, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 52 , 78 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6MidCodi" );
         ((GXEdit) edtavMidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavMidcodigo.addFocusListener(this);
         edtavMidcodigo.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         cmbavMidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 169 , 78 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8MidTipo" );
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(0),"Todos");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbavMidtipo.addFocusListener(this);
         cmbavMidtipo.addItemListener(this);
         cmbavMidtipo.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFilnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),247, 78, 377, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 247 , 78 , 377 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5FilNome" );
         ((GXEdit) edtavFilnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFilnome.addFocusListener(this);
         edtavFilnome.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFildata = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),52, 117, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 52 , 117 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV44FilDat" );
         ((GXEdit) edtavFildata.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFildata.addFocusListener(this);
         edtavFildata.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavCatnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),143, 117, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 143 , 117 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV45CatNom" );
         ((GXEdit) edtavCatnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCatnome.addFocusListener(this);
         edtavCatnome.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFilatocodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),52, 156, 104, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 52 , 156 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13FilAto" );
         ((GXEdit) edtavFilatocodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilatocodigo.addFocusListener(this);
         edtavFilatocodigo.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFilatonome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),169, 156, 338, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 169 , 156 , 338 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV14FilAto" );
         ((GXEdit) edtavFilatonome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFilatonome.addFocusListener(this);
         edtavFilatonome.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         chkavFilatoprot = new GUIObjectShort ( new GXCheckBox(GXPanel1, "Protagonista" , new java.lang.Short(1), new java.lang.Short(0)) , GXPanel1 , 520 , 159 , 105 , 16 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV12FilAto" );
         chkavFilatoprot.addFocusListener(this);
         chkavFilatoprot.addItemListener(this);
         chkavFilatoprot.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFildircodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),52, 195, 104, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 52 , 195 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV17FilDir" );
         ((GXEdit) edtavFildircodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFildircodigo.addFocusListener(this);
         edtavFildircodigo.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         edtavFildirnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),169, 195, 338, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 169 , 195 , 338 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV18FilDir" );
         ((GXEdit) edtavFildirnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFildirnome.addFocusListener(this);
         edtavFildirnome.getGXComponent().setHelpId("HLP_WConsMidia.htm");
         addSubfile ( subGxsf8  = new GXSubfile ( new ConsMidia_load08(this), new ConsMidia_flow08(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 66, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 65 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A37MidCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 65 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 101, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 100 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "Código do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 100 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 351, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 350 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" ), "Nome da mídia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 350 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" ), "Nome da categoria do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 172, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 171 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A31FilData" ), "Data de lançamento do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 171 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 90 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" ), "Tipo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 90 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 98 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A36MidSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 98 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 90, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 89 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A85ConfTip" ), "Valor (em R$)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 89 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 80, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 79 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13FilAto" ), "Código do astro."  , UIFactory.getColor(18) , UIFactory.getColor(15) , 79 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV14FilAto" ), "Nome do astro."  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , false )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 103, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 102 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV17FilDir" ), "Código do astro."  , UIFactory.getColor(18) , UIFactory.getColor(15) , 102 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV18FilDir" ), "Nome do astro."  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , false )
         }, 32 , 18 , GXPanel1 , 52 , 221 , 753 , 598 ,  18 ));
         ((GXComboBox) subGxsf8.getColumn(5).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGxsf8.getColumn(5).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGxsf8.getColumn(5).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGxsf8.getColumn(5).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         ((GXComboBox) subGxsf8.getColumn(6).getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) subGxsf8.getColumn(6).getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         subGxsf8.addActionListener(this);
         subGxsf8.addFocusListener(this);
         subGxsf8.setSortOnClick(true);
         subGxsf8.getColumn(0).addActionListener( this);
         subGxsf8.getColumn(0).addItemListener( this);
         subGxsf8.getColumn(8).addActionListener( this);
         subGxsf8.getColumn(8).addItemListener( this);
         lbllbl21 = UIFactory.getLabel(GXPanel1, "Consulta de mídias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 26 , 109 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 65 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Tipo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 169 , 65 , 26 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Nome da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 247 , 65 , 86 , 13 );
         lbllbl34 = UIFactory.getLabel(GXPanel1, "Estreia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 104 , 40 , 13 );
         lbllbl35 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 143 , 104 , 55 , 13 );
         lbllbl22 = UIFactory.getLabel(GXPanel1, "Código do ator", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 143 , 84 , 13 );
         lbllbl23 = UIFactory.getLabel(GXPanel1, "Nome do ator", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 169 , 143 , 77 , 13 );
         lbllbl29 = UIFactory.getLabel(GXPanel1, "Código do diretor", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 182 , 98 , 13 );
         lbllbl30 = UIFactory.getLabel(GXPanel1, "Nome do diretor", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 169 , 182 , 91 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavAstcodigo ,
                   edtavMidcodigo ,
                   cmbavMidtipo ,
                   edtavFilnome ,
                   edtavFildata ,
                   edtavCatnome ,
                   edtavFilatocodigo ,
                   edtavFilatonome ,
                   chkavFilatoprot ,
                   edtavFildircodigo ,
                   edtavFildirnome ,
                   subGxsf8
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf8, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile08( )
      {
         subwconsmidia08.setMidCodigo(A37MidCodi);
         subwconsmidia08.setFilCodigo(A28FilCodi);
         subwconsmidia08.setFilNome(A29FilNome);
         subwconsmidia08.setCatNome(A33CatNome);
         subwconsmidia08.setFilData(A31FilData);
         subwconsmidia08.setMidTipo(A35MidTipo);
         subwconsmidia08.setMidSituacao(A36MidSitu);
         subwconsmidia08.setConfTipValor(A85ConfTip);
         subwconsmidia08.setVFilAtoCodigo(AV13FilAto);
         subwconsmidia08.setVFilAtoNome(AV14FilAto);
         subwconsmidia08.setVFilDirCodigo(AV17FilDir);
         subwconsmidia08.setVFilDirNome(AV18FilDir);
      }

      protected void subfileToVariables08( )
      {
         A37MidCodi = subwconsmidia08.getMidCodigo();
         A28FilCodi = subwconsmidia08.getFilCodigo();
         A29FilNome = subwconsmidia08.getFilNome();
         A33CatNome = subwconsmidia08.getCatNome();
         A31FilData = subwconsmidia08.getFilData();
         A35MidTipo = subwconsmidia08.getMidTipo();
         A36MidSitu = subwconsmidia08.getMidSituacao();
         A85ConfTip = subwconsmidia08.getConfTipValor();
         AV13FilAto = subwconsmidia08.getVFilAtoCodigo();
         AV14FilAto = subwconsmidia08.getVFilAtoNome();
         AV17FilDir = subwconsmidia08.getVFilDirCodigo();
         AV18FilDir = subwconsmidia08.getVFilDirNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavMidcodigo.setValue( AV6MidCodi );
         edtavFilnome.setValue( AV5FilNome );
         cmbavMidtipo.setValue( AV8MidTipo );
         chkavFilatoprot.setValue( AV12FilAto );
         edtavFilatocodigo.setValue( AV13FilAto );
         edtavFilatonome.setValue( AV14FilAto );
         edtavFildircodigo.setValue( AV17FilDir );
         edtavFildirnome.setValue( AV18FilDir );
         edtavFildata.setValue( AV44FilDat );
         edtavCatnome.setValue( AV45CatNom );
         edtavAstcodigo.setValue( AV10AstCod );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV6MidCodi = (int)(edtavMidcodigo.getValue()) ;
         edtavMidcodigo.setValue(AV6MidCodi);
         AV5FilNome = (String)(edtavFilnome.getValue()) ;
         edtavFilnome.setValue(AV5FilNome);
         AV8MidTipo = (short)(cmbavMidtipo.getValue()) ;
         cmbavMidtipo.setValue(AV8MidTipo);
         AV12FilAto = (short)(chkavFilatoprot.getValue()) ;
         chkavFilatoprot.setValue(AV12FilAto);
         AV13FilAto = (int)(edtavFilatocodigo.getValue()) ;
         edtavFilatocodigo.setValue(AV13FilAto);
         AV14FilAto = (String)(edtavFilatonome.getValue()) ;
         edtavFilatonome.setValue(AV14FilAto);
         AV17FilDir = (int)(edtavFildircodigo.getValue()) ;
         edtavFildircodigo.setValue(AV17FilDir);
         AV18FilDir = (String)(edtavFildirnome.getValue()) ;
         edtavFildirnome.setValue(AV18FilDir);
         AV44FilDat = (DateTime)(edtavFildata.getValue()) ;
         edtavFildata.setValue(AV44FilDat);
         AV45CatNom = (String)(edtavCatnome.getValue()) ;
         edtavCatnome.setValue(AV45CatNom);
         AV10AstCod = (int)(edtavAstcodigo.getValue()) ;
         edtavAstcodigo.setValue(AV10AstCod);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf8.inValidElement() )
         {
            subwconsmidia08 = ( subwconsmidia08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsmidia08 = new subwconsmidia08 ();
         }
         subfileToVariables08 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile08 ();
         subGxsf8.refreshLineValue(subwconsmidia08);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf8.inValidElement() )
         {
            subwconsmidia08 = ( subwconsmidia08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsmidia08 = new subwconsmidia08 ();
         }
         subfileToVariables08 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf8.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E14V0N2 */
            E14V0N2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavMidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavMidcodigo.getGXCursor() );
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            setGXCursor( edtavFilnome.getGXCursor() );
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavMidtipo.getGXCursor() );
            return;
         }
         if ( chkavFilatoprot.isEventSource(eventSource) ) {
            setGXCursor( chkavFilatoprot.getGXCursor() );
            return;
         }
         if ( edtavFilatocodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavFilatocodigo.getGXCursor() );
            return;
         }
         if ( edtavFilatonome.isEventSource(eventSource) ) {
            setGXCursor( edtavFilatonome.getGXCursor() );
            return;
         }
         if ( edtavFildircodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavFildircodigo.getGXCursor() );
            return;
         }
         if ( edtavFildirnome.isEventSource(eventSource) ) {
            setGXCursor( edtavFildirnome.getGXCursor() );
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            setGXCursor( edtavFildata.getGXCursor() );
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCatnome.getGXCursor() );
            return;
         }
         if ( edtavAstcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavAstcodigo.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         if ( edtavFilatocodigo.isEventSource(eventSource) ) {
            /* Execute user event: E16V0N2 */
            E16V0N2 ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavMidcodigo.isEventSource(eventSource) ) {
            AV6MidCodi = edtavMidcodigo.getValue() ;
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            AV5FilNome = edtavFilnome.getValue() ;
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            AV8MidTipo = cmbavMidtipo.getValue() ;
            return;
         }
         if ( chkavFilatoprot.isEventSource(eventSource) ) {
            AV12FilAto = chkavFilatoprot.getValue() ;
            return;
         }
         if ( edtavFilatocodigo.isEventSource(eventSource) ) {
            AV13FilAto = edtavFilatocodigo.getValue() ;
            return;
         }
         if ( edtavFilatonome.isEventSource(eventSource) ) {
            AV14FilAto = edtavFilatonome.getValue() ;
            return;
         }
         if ( edtavFildircodigo.isEventSource(eventSource) ) {
            AV17FilDir = edtavFildircodigo.getValue() ;
            return;
         }
         if ( edtavFildirnome.isEventSource(eventSource) ) {
            AV18FilDir = edtavFildirnome.getValue() ;
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            AV44FilDat = edtavFildata.getValue() ;
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            AV45CatNom = edtavCatnome.getValue() ;
            return;
         }
         if ( edtavAstcodigo.isEventSource(eventSource) ) {
            AV10AstCod = edtavAstcodigo.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0N2 */
            E14V0N2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E15V0N2 */
            E15V0N2 ();
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
            /* Execute user event: E13V0N2 */
            E13V0N2 ();
         }
         this.AV32MidCod = AV32MidCod;
         this.AV41FilCod = AV41FilCod;
         this.AV36FilNom = AV36FilNom;
         this.AV43CatCod = AV43CatCod;
         this.AV34MidTip = AV34MidTip;
         this.AV35LocMid = AV35LocMid;
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         subwconsmidia08 = new subwconsmidia08();
         scmdbuf = "" ;
         AV6MidCodi = 0 ;
         AV5FilNome = "" ;
         AV8MidTipo = 0 ;
         AV44FilDat = (DateTime)(DateTime.MinValue) ;
         AV45CatNom = "" ;
         A37MidCodi = 0 ;
         A29FilNome = "" ;
         A35MidTipo = 0 ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         A33CatNome = "" ;
         A85ConfTip = (decimal)(0M) ;
         A36MidSitu = 0 ;
         W000N2_A32CatCodi = new int[1] ;
         W000N2_n32CatCodi = new bool[] {false} ;
         W000N2_A85ConfTip = new decimal[1] ;
         W000N2_n85ConfTip = new bool[] {false} ;
         W000N2_A36MidSitu = new short[1] ;
         W000N2_n36MidSitu = new bool[] {false} ;
         W000N2_A35MidTipo = new short[1] ;
         W000N2_n35MidTipo = new bool[] {false} ;
         W000N2_A31FilData = new DateTime[] {DateTime.MinValue} ;
         W000N2_n31FilData = new bool[] {false} ;
         W000N2_A33CatNome = new String[] {""} ;
         W000N2_n33CatNome = new bool[] {false} ;
         W000N2_A29FilNome = new String[] {""} ;
         W000N2_n29FilNome = new bool[] {false} ;
         W000N2_A28FilCodi = new int[1] ;
         W000N2_n28FilCodi = new bool[] {false} ;
         W000N2_A37MidCodi = new int[1] ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         n85ConfTip = false ;
         n36MidSitu = false ;
         n35MidTipo = false ;
         n31FilData = false ;
         n33CatNome = false ;
         n29FilNome = false ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         W000N3_A28FilCodi = new int[1] ;
         W000N3_n28FilCodi = new bool[] {false} ;
         W000N3_A32CatCodi = new int[1] ;
         W000N3_n32CatCodi = new bool[] {false} ;
         W000N4_A32CatCodi = new int[1] ;
         W000N4_n32CatCodi = new bool[] {false} ;
         W000N4_A35MidTipo = new short[1] ;
         W000N4_n35MidTipo = new bool[] {false} ;
         W000N4_A85ConfTip = new decimal[1] ;
         W000N4_n85ConfTip = new bool[] {false} ;
         AV13FilAto = 0 ;
         AV17FilDir = 0 ;
         AV14FilAto = "" ;
         AV18FilDir = "" ;
         AV15FilCod = 0 ;
         AV12FilAto = 0 ;
         A77FilAtoC = 0 ;
         A81FilAtoP = 0 ;
         AV19FilAto = 0 ;
         W000N5_A28FilCodi = new int[1] ;
         W000N5_n28FilCodi = new bool[] {false} ;
         W000N5_A81FilAtoP = new short[1] ;
         W000N5_n81FilAtoP = new bool[] {false} ;
         W000N5_A77FilAtoC = new int[1] ;
         n81FilAtoP = false ;
         A79FilDirC = 0 ;
         A80FilDirN = "" ;
         W000N6_A28FilCodi = new int[1] ;
         W000N6_n28FilCodi = new bool[] {false} ;
         W000N6_A80FilDirN = new String[] {""} ;
         W000N6_n80FilDirN = new bool[] {false} ;
         W000N6_A79FilDirC = new int[1] ;
         n80FilDirN = false ;
         AV10AstCod = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconsmidia__default(),
            new Object[][] {
                new Object[] {
               W000N2_A32CatCodi, W000N2_n32CatCodi, W000N2_A85ConfTip, W000N2_n85ConfTip, W000N2_A36MidSitu, W000N2_n36MidSitu, W000N2_A35MidTipo, W000N2_n35MidTipo, W000N2_A31FilData, W000N2_n31FilData,
               W000N2_A33CatNome, W000N2_n33CatNome, W000N2_A29FilNome, W000N2_n29FilNome, W000N2_A28FilCodi, W000N2_n28FilCodi, W000N2_A37MidCodi
               }
               , new Object[] {
               W000N3_A28FilCodi, W000N3_A32CatCodi, W000N3_n32CatCodi
               }
               , new Object[] {
               W000N4_A32CatCodi, W000N4_A35MidTipo, W000N4_A85ConfTip, W000N4_n85ConfTip
               }
               , new Object[] {
               W000N5_A28FilCodi, W000N5_A81FilAtoP, W000N5_n81FilAtoP, W000N5_A77FilAtoC
               }
               , new Object[] {
               W000N6_A28FilCodi, W000N6_A80FilDirN, W000N6_n80FilDirN, W000N6_A79FilDirC
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV8MidTipo ;
      protected short A35MidTipo ;
      protected short A36MidSitu ;
      protected short AV34MidTip ;
      protected short AV12FilAto ;
      protected short A81FilAtoP ;
      protected int AV6MidCodi ;
      protected int A37MidCodi ;
      protected int A32CatCodi ;
      protected int A28FilCodi ;
      protected int AV32MidCod ;
      protected int AV41FilCod ;
      protected int AV43CatCod ;
      protected int AV13FilAto ;
      protected int AV17FilDir ;
      protected int AV15FilCod ;
      protected int A77FilAtoC ;
      protected int AV19FilAto ;
      protected int A79FilDirC ;
      protected int AV10AstCod ;
      protected decimal A85ConfTip ;
      protected decimal AV35LocMid ;
      protected String scmdbuf ;
      protected DateTime AV44FilDat ;
      protected DateTime A31FilData ;
      protected bool n32CatCodi ;
      protected bool n85ConfTip ;
      protected bool n36MidSitu ;
      protected bool n35MidTipo ;
      protected bool n31FilData ;
      protected bool n33CatNome ;
      protected bool n29FilNome ;
      protected bool n28FilCodi ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected bool n81FilAtoP ;
      protected bool n80FilDirN ;
      protected String AV5FilNome ;
      protected String AV45CatNom ;
      protected String A29FilNome ;
      protected String A33CatNome ;
      protected String AV36FilNom ;
      protected String AV14FilAto ;
      protected String AV18FilDir ;
      protected String A80FilDirN ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconsmidia08 subwconsmidia08 ;
      protected IDataReader W000N2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000N2_A32CatCodi ;
      protected bool[] W000N2_n32CatCodi ;
      protected decimal[] W000N2_A85ConfTip ;
      protected bool[] W000N2_n85ConfTip ;
      protected short[] W000N2_A36MidSitu ;
      protected bool[] W000N2_n36MidSitu ;
      protected short[] W000N2_A35MidTipo ;
      protected bool[] W000N2_n35MidTipo ;
      protected DateTime[] W000N2_A31FilData ;
      protected bool[] W000N2_n31FilData ;
      protected String[] W000N2_A33CatNome ;
      protected bool[] W000N2_n33CatNome ;
      protected String[] W000N2_A29FilNome ;
      protected bool[] W000N2_n29FilNome ;
      protected int[] W000N2_A28FilCodi ;
      protected bool[] W000N2_n28FilCodi ;
      protected int[] W000N2_A37MidCodi ;
      protected IDataReader W000N3 ;
      protected int[] W000N3_A28FilCodi ;
      protected bool[] W000N3_n28FilCodi ;
      protected int[] W000N3_A32CatCodi ;
      protected bool[] W000N3_n32CatCodi ;
      protected IDataReader W000N4 ;
      protected int[] W000N4_A32CatCodi ;
      protected bool[] W000N4_n32CatCodi ;
      protected short[] W000N4_A35MidTipo ;
      protected bool[] W000N4_n35MidTipo ;
      protected decimal[] W000N4_A85ConfTip ;
      protected bool[] W000N4_n85ConfTip ;
      protected IDataReader W000N5 ;
      protected int[] W000N5_A28FilCodi ;
      protected bool[] W000N5_n28FilCodi ;
      protected short[] W000N5_A81FilAtoP ;
      protected bool[] W000N5_n81FilAtoP ;
      protected int[] W000N5_A77FilAtoC ;
      protected IDataReader W000N6 ;
      protected int[] W000N6_A28FilCodi ;
      protected bool[] W000N6_n28FilCodi ;
      protected String[] W000N6_A80FilDirN ;
      protected bool[] W000N6_n80FilDirN ;
      protected int[] W000N6_A79FilDirC ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavAstcodigo ;
      protected GUIObjectInt edtavMidcodigo ;
      protected GUIObjectShort cmbavMidtipo ;
      protected GUIObjectString edtavFilnome ;
      protected GUIObjectDatetime edtavFildata ;
      protected GUIObjectString edtavCatnome ;
      protected GUIObjectInt edtavFilatocodigo ;
      protected GUIObjectString edtavFilatonome ;
      protected GUIObjectShort chkavFilatoprot ;
      protected GUIObjectInt edtavFildircodigo ;
      protected GUIObjectString edtavFildirnome ;
      protected GXSubfile subGxsf8 ;
      protected ILabel lbllbl21 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl34 ;
      protected ILabel lbllbl35 ;
      protected ILabel lbllbl22 ;
      protected ILabel lbllbl23 ;
      protected ILabel lbllbl29 ;
      protected ILabel lbllbl30 ;
      protected int aP0_MidCodRetornado ;
      protected int aP1_FilCodRetornado ;
      protected String aP2_FilNomRetornado ;
      protected int aP3_CatCodRetornado ;
      protected short aP4_MidTipRetornado ;
      protected decimal aP5_LocMidValRetornado ;
   }

   public class wconsmidia__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000N2( int AV6MidCodi ,
                                           String AV5FilNome ,
                                           short AV8MidTipo ,
                                           DateTime AV44FilDat ,
                                           String AV45CatNom ,
                                           int A37MidCodi ,
                                           String A29FilNome ,
                                           short A35MidTipo ,
                                           DateTime A31FilData ,
                                           String A33CatNome ,
                                           decimal A85ConfTip ,
                                           short A36MidSitu )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T2.[CatCodigo], T4.[ConfTipValor], T1.[MidSituacao], T1.[MidTipo], T2.[FilData], T3.[CatNome], T2.[FilNome], T1.[FilCodigo], T1.[MidCodigo] FROM ((([MIDIA] T1 WITH (NOLOCK) LEFT JOIN [FILME] T2 WITH (NOLOCK) ON T2.[FilCodigo] = T1.[FilCodigo]) LEFT JOIN [CATEGORIA] T3 WITH (NOLOCK) ON T3.[CatCodigo] = T2.[CatCodigo]) LEFT JOIN [CONFTIPMIDIA] T4 WITH (NOLOCK) ON T4.[MidTipo] = T1.[MidTipo] AND T4.[CatCodigo] = T2.[CatCodigo])" ;
         scmdbuf = scmdbuf + " WHERE (T4.[ConfTipValor] > 0)" ;
         scmdbuf = scmdbuf + " and (T1.[MidSituacao] = 1)" ;
         sWhereString = "" ;
         if ( ( AV6MidCodi != 0 ) )
         {
            sWhereString = sWhereString + " and (T1.[MidCodigo] = " + StringUtil.Str( (decimal)(AV6MidCodi), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV5FilNome).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and (T2.[FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV5FilNome, "'", "''")), 50, "%") + "')" ;
         }
         if ( ( AV8MidTipo != 0 ) )
         {
            sWhereString = sWhereString + " and (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV8MidTipo), 1, 0) + ")" ;
         }
         if ( ( AV44FilDat != DateTimeUtil.CToD( "0", 2) ) )
         {
            sWhereString = sWhereString + " and (T2.[FilData] = " + ((AV44FilDat>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV44FilDat, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV45CatNom).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and (T3.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV45CatNom, "'", "''")), 50, "%") + "')" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[MidCodigo]" ;
         return scmdbuf;
      }

      protected String conditional_W000N5( int AV13FilAto ,
                                           short AV12FilAto ,
                                           String AV14FilAto ,
                                           int A77FilAtoC ,
                                           short A81FilAtoP ,
                                           int AV19FilAto ,
                                           int A28FilCodi )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [FilCodigo], [FilAtoProt], [FilAtoCodigo] FROM [FILMEELENCO] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([FilCodigo] = " + StringUtil.Str( (decimal)(AV19FilAto), 9, 0) + ")" ;
         sWhereString = "" ;
         if ( ( AV13FilAto != 0 ) )
         {
            sWhereString = sWhereString + " and ([FilAtoCodigo] = " + StringUtil.Str( (decimal)(AV13FilAto), 9, 0) + ")" ;
         }
         if ( ( AV12FilAto != 0 ) && ! ( AV13FilAto == 0 ) || ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV14FilAto).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([FilAtoProt] = " + StringUtil.Str( (decimal)(AV12FilAto), 1, 0) + ")" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [FilCodigo]" ;
         return scmdbuf;
      }

      protected String conditional_W000N6( int AV17FilDir ,
                                           String AV18FilDir ,
                                           int A79FilDirC ,
                                           String A80FilDirN ,
                                           int A28FilCodi )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[FilCodigo], T2.[AstNome] AS FilDirNome, T1.[FilDirCodigo] AS FilDirCodigo FROM ([FILMEDIRECAO] T1 WITH (NOLOCK) INNER JOIN [ASTRO] T2 WITH (NOLOCK) ON T2.[AstCodigo] = T1.[FilDirCodigo])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[FilCodigo] = " + StringUtil.Str( (decimal)(A28FilCodi), 9, 0) + ")" ;
         sWhereString = "" ;
         if ( ( AV17FilDir != 0 ) )
         {
            sWhereString = sWhereString + " and (T1.[FilDirCodigo] = " + StringUtil.Str( (decimal)(AV17FilDir), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV18FilDir).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and (T2.[AstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV18FilDir, "'", "''")), 50, "%") + "')" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[FilCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000N2( (int)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (DateTime)dynConstraints[3] , (String)dynConstraints[4] , (int)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (DateTime)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (short)dynConstraints[11] );
               case 3 :
                     return conditional_W000N5( (int)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (int)dynConstraints[3] , (short)dynConstraints[4] , (int)dynConstraints[5] , (int)dynConstraints[6] );
               case 4 :
                     return conditional_W000N6( (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW000N3 ;
          prmW000N3 = new Object[] {
          new Object[] {"@AV41FilCod",SqlDbType.Int,9,0}
          } ;
          Object[] prmW000N4 ;
          prmW000N4 = new Object[] {
          new Object[] {"@AV34MidTip",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV43CatCod",SqlDbType.Int,9,0}
          } ;
          Object[] prmW000N2 ;
          prmW000N2 = new Object[] {
          } ;
          Object[] prmW000N5 ;
          prmW000N5 = new Object[] {
          } ;
          Object[] prmW000N6 ;
          prmW000N6 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000N2,26,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000N3", "SELECT TOP 1 [FilCodigo], [CatCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @AV41FilCod ORDER BY [FilCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000N3,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000N4", "SELECT TOP 1 [CatCodigo], [MidTipo], [ConfTipValor] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE [MidTipo] = @AV34MidTip and [CatCodigo] = @AV43CatCod ORDER BY [MidTipo], [CatCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000N4,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000N5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000N5,26,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000N6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000N6,26,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((int[]) buf[16])[0] = rslt.getInt(9) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
