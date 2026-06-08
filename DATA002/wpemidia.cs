/*
               File: PeMidia
        Description: Cadastro de mídias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/8/2026 11:43:22.79
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
   public class wpemidia : GXWorkpanel
   {
      public wpemidia( int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpemidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpemidia( IGxContext context ,
                       int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeMidia" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de mídias." ;
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
         return 1040 ;
      }

      public override int getFrmHeight( )
      {
         return 793 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeMidia.htm";
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
         return false;
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

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
         GXV_CATNOME_htmlV0E2( ) ;
      }

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpemidia02 = new subwpemidia02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5FilCodi ,
                                              AV6FilNome ,
                                              AV12FilDat ,
                                              AV13CatNom ,
                                              AV9MidTipo ,
                                              AV8MidSitu ,
                                              A28FilCodi ,
                                              A29FilNome ,
                                              A31FilData ,
                                              A33CatNome ,
                                              A35MidTipo ,
                                              A36MidSitu },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000E2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A32CatCodi = W000E2_A32CatCodi[0] ;
            n32CatCodi = W000E2_n32CatCodi[0] ;
            A33CatNome = W000E2_A33CatNome[0] ;
            n33CatNome = W000E2_n33CatNome[0] ;
            A85ConfTip = W000E2_A85ConfTip[0] ;
            n85ConfTip = W000E2_n85ConfTip[0] ;
            A31FilData = W000E2_A31FilData[0] ;
            n31FilData = W000E2_n31FilData[0] ;
            A29FilNome = W000E2_A29FilNome[0] ;
            n29FilNome = W000E2_n29FilNome[0] ;
            A28FilCodi = W000E2_A28FilCodi[0] ;
            n28FilCodi = W000E2_n28FilCodi[0] ;
            A36MidSitu = W000E2_A36MidSitu[0] ;
            n36MidSitu = W000E2_n36MidSitu[0] ;
            A35MidTipo = W000E2_A35MidTipo[0] ;
            n35MidTipo = W000E2_n35MidTipo[0] ;
            A37MidCodi = W000E2_A37MidCodi[0] ;
            A32CatCodi = W000E2_A32CatCodi[0] ;
            n32CatCodi = W000E2_n32CatCodi[0] ;
            A31FilData = W000E2_A31FilData[0] ;
            n31FilData = W000E2_n31FilData[0] ;
            A29FilNome = W000E2_A29FilNome[0] ;
            n29FilNome = W000E2_n29FilNome[0] ;
            A33CatNome = W000E2_A33CatNome[0] ;
            n33CatNome = W000E2_n33CatNome[0] ;
            A85ConfTip = W000E2_A85ConfTip[0] ;
            n85ConfTip = W000E2_n85ConfTip[0] ;
            /* Execute user event: E11V0E2 */
            E11V0E2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeMidia_load02 : GXLoadProducer
      {
         wpemidia _sf ;

         public PeMidia_load02( wpemidia uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer02();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load02();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors02();
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
            subGxsf2.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow02( )
      {
         return true;
      }

      public void autoRefresh_flow02( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow02() )) {
            subfile.refresh();
            resetSubfileConditions_flow02() ;
         }
      }

      public bool getSearch_flow02( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow02( )
      {
      }

      public void resetSearchConditions_flow02( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow02( )
      {
         return new subwpemidia02 ();
      }

      public bool getSearch_flow02( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow02( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow02( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow02( )
      {
         GXRefreshCommand02 ();
      }

      public class PeMidia_flow02 : GXSubfileFlow
      {
         wpemidia _sf ;

         public PeMidia_flow02( wpemidia uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow02();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow02(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow02();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow02();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow02(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow02();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow02(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow02(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow02(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow02();
         }

      }

      protected void GXRefreshCommand02( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer02( )
      {
         subwpemidia02 oAux = subwpemidia02 ;
         subwpemidia02 = new subwpemidia02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwpemidia02);
         subwpemidia02 = oAux;
      }

      private void E11V0E2( )
      {
         /* Load Routine */
         AV11Exclui = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV10Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV15Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E12V0E2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tmidia(context, base.remoteHandle, base.context).execute(  A37MidCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E13V0E2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tmidia(context, base.remoteHandle, base.context).execute(  A37MidCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E14V0E2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tmidia(context, base.remoteHandle, base.context).execute(  A37MidCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E15V0E2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tmidia(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1040 , 793 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavFilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 78, 78, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 78 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5FilCodi" );
         ((GXEdit) edtavFilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodigo.addFocusListener(this);
         edtavFilcodigo.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         edtavFilnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 78, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 78 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6FilNome" );
         ((GXEdit) edtavFilnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFilnome.addFocusListener(this);
         edtavFilnome.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         edtavFildata = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),533, 78, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 533 , 78 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV12FilDat" );
         ((GXEdit) edtavFildata.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFildata.addFocusListener(this);
         edtavFildata.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         dynavCatnome = new GUIObjectString ( new GXComboBox(GXPanel1, this, 22) , GXPanel1 , 65 , 117 , 364 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13CatNom" );
         dynavCatnome.addFocusListener(this);
         dynavCatnome.addItemListener(this);
         dynavCatnome.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         cmbavMidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 442 , 117 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9MidTipo" );
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(0),"Todas");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         cmbavMidtipo.addFocusListener(this);
         cmbavMidtipo.addItemListener(this);
         cmbavMidtipo.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         cmbavMidsituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 533 , 117 , 82 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8MidSitu" );
         ((GXComboBox) cmbavMidsituacao.getGXComponent()).addItem( new java.lang.Short(0),"Todos");
         ((GXComboBox) cmbavMidsituacao.getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) cmbavMidsituacao.getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         cmbavMidsituacao.addFocusListener(this);
         cmbavMidsituacao.addItemListener(this);
         cmbavMidsituacao.getGXComponent().setHelpId("HLP_WPeMidia.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new PeMidia_load02(this), new PeMidia_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV15Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV10Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV11Exclui" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 65, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 64 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A37MidCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 64 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 77 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" ), "Tipo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 77 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 85 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A36MidSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 85 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 104, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 103 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "Código do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 103 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 313, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 312 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" ), "Título"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 312 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 176, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 175 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A31FilData" ), "Data"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 175 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 135, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 134 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A85ConfTip" ), "Valor (em R$)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 134 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 33 , 18 , GXPanel1 , 65 , 143 , 917 , 624 ,  18 ));
         ((GXComboBox) subGxsf2.getColumn(4).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGxsf2.getColumn(4).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGxsf2.getColumn(4).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGxsf2.getColumn(4).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         ((GXComboBox) subGxsf2.getColumn(5).getGXComponent()).addItem( new java.lang.Short(1),"Liberado");
         ((GXComboBox) subGxsf2.getColumn(5).getGXComponent()).addItem( new java.lang.Short(2),"Locado");
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.addItemListener(this);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         subGxsf2.getColumn(1).addActionListener( this);
         subGxsf2.getColumn(1).addItemListener( this);
         subGxsf2.getColumn(2).addActionListener( this);
         subGxsf2.getColumn(2).addItemListener( this);
         bttbtt25 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  845 ,  104 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt25.setTooltip("Novo");
         bttbtt25.addActionListener(this);
         bttbtt25.setFiresEvents(false);
         lbllbl26 = UIFactory.getLabel(GXPanel1, "Cadastro de mídias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 110 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 78 , 13 );
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Nome da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 65 , 104 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Data", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 533 , 65 , 78 , 26 );
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 104 , 78 , 13 );
         lbllbl18 = UIFactory.getLabel(GXPanel1, "Tipo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 442 , 104 , 78 , 26 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 533 , 104 , 78 , 26 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavFilcodigo ,
                   edtavFilnome ,
                   edtavFildata ,
                   dynavCatnome ,
                   cmbavMidtipo ,
                   cmbavMidsituacao ,
                   subGxsf2 ,
                   bttbtt25
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf2, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile02( )
      {
         subwpemidia02.setVVisualizar(AV15Visual);
         subwpemidia02.setVEditar(AV10Editar);
         subwpemidia02.setVExcluir(AV11Exclui);
         subwpemidia02.setMidCodigo(A37MidCodi);
         subwpemidia02.setMidTipo(A35MidTipo);
         subwpemidia02.setMidSituacao(A36MidSitu);
         subwpemidia02.setFilCodigo(A28FilCodi);
         subwpemidia02.setFilNome(A29FilNome);
         subwpemidia02.setFilData(A31FilData);
         subwpemidia02.setConfTipValor(A85ConfTip);
      }

      protected void subfileToVariables02( )
      {
         AV15Visual = subwpemidia02.getVVisualizar();
         AV10Editar = subwpemidia02.getVEditar();
         AV11Exclui = subwpemidia02.getVExcluir();
         A37MidCodi = subwpemidia02.getMidCodigo();
         A35MidTipo = subwpemidia02.getMidTipo();
         A36MidSitu = subwpemidia02.getMidSituacao();
         A28FilCodi = subwpemidia02.getFilCodigo();
         A29FilNome = subwpemidia02.getFilNome();
         A31FilData = subwpemidia02.getFilData();
         A85ConfTip = subwpemidia02.getConfTipValor();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavFilcodigo.setValue( AV5FilCodi );
         edtavFilnome.setValue( AV6FilNome );
         edtavFildata.setValue( AV12FilDat );
         dynavCatnome.setValue( AV13CatNom );
         cmbavMidtipo.setValue( AV9MidTipo );
         cmbavMidsituacao.setValue( AV8MidSitu );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5FilCodi = (int)(edtavFilcodigo.getValue()) ;
         edtavFilcodigo.setValue(AV5FilCodi);
         AV6FilNome = (String)(edtavFilnome.getValue()) ;
         edtavFilnome.setValue(AV6FilNome);
         AV12FilDat = (DateTime)(edtavFildata.getValue()) ;
         edtavFildata.setValue(AV12FilDat);
         AV13CatNom = (String)(dynavCatnome.getValue()) ;
         dynavCatnome.setValue(AV13CatNom);
         AV9MidTipo = (short)(cmbavMidtipo.getValue()) ;
         cmbavMidtipo.setValue(AV9MidTipo);
         AV8MidSitu = (short)(cmbavMidsituacao.getValue()) ;
         cmbavMidsituacao.setValue(AV8MidSitu);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf2.inValidElement() )
         {
            subwpemidia02 = ( subwpemidia02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpemidia02 = new subwpemidia02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwpemidia02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwpemidia02 = ( subwpemidia02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpemidia02 = new subwpemidia02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt25.isEventSource(eventSource) ) {
            /* Execute user event: E15V0E2 */
            E15V0E2 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E12V0E2 */
            E12V0E2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E13V0E2 */
            E13V0E2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E14V0E2 */
            E14V0E2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodigo.getGXCursor() );
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            setGXCursor( edtavFilnome.getGXCursor() );
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            setGXCursor( edtavFildata.getGXCursor() );
            return;
         }
         if ( dynavCatnome.isEventSource(eventSource) ) {
            setGXCursor( dynavCatnome.getGXCursor() );
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavMidtipo.getGXCursor() );
            return;
         }
         if ( cmbavMidsituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavMidsituacao.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            GXV_CATNOME_htmlV0E2( ) ;
            VariablesToControls();
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            AV5FilCodi = edtavFilcodigo.getValue() ;
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            AV6FilNome = edtavFilnome.getValue() ;
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            AV12FilDat = edtavFildata.getValue() ;
            return;
         }
         if ( dynavCatnome.isEventSource(eventSource) ) {
            AV13CatNom = dynavCatnome.getValue() ;
            return;
         }
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            AV9MidTipo = cmbavMidtipo.getValue() ;
            return;
         }
         if ( cmbavMidsituacao.isEventSource(eventSource) ) {
            AV8MidSitu = cmbavMidsituacao.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E12V0E2 */
            E12V0E2 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0E2 */
            E13V0E2 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0E2 */
            E14V0E2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
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

      protected void GXV_CATNOME_htmlV0E2( )
      {
         String gxdynajaxvalue ;
         GXDLV_CATNOME_dataV0E2( ) ;
         gxdynajaxindex = 1 ;
         while ( ( gxdynajaxindex <= gxdynajaxctrlcodr.Count ) )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            ((GXComboBox) dynavCatnome.getGXComponent()).addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), (short)(gxdynajaxindex));
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         ((GXComboBox) dynavCatnome.getGXComponent()).removeAllItemsFrom(gxdynajaxindex);
      }

      protected void GXDLV_CATNOME_dataV0E2( )
      {
         /* Using cursor W000E3 */
         pr_default.execute(1);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Selecione uma categoria.");
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( W000E3_A33CatNome[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( W000E3_A33CatNome[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
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
         subwpemidia02 = new subwpemidia02();
         scmdbuf = "" ;
         AV5FilCodi = 0 ;
         AV6FilNome = "" ;
         AV12FilDat = (DateTime)(DateTime.MinValue) ;
         AV13CatNom = "" ;
         AV9MidTipo = 0 ;
         AV8MidSitu = 0 ;
         A28FilCodi = 0 ;
         A29FilNome = "" ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         A33CatNome = "" ;
         A35MidTipo = 0 ;
         A36MidSitu = 0 ;
         W000E2_A32CatCodi = new int[1] ;
         W000E2_n32CatCodi = new bool[] {false} ;
         W000E2_A33CatNome = new String[] {""} ;
         W000E2_n33CatNome = new bool[] {false} ;
         W000E2_A85ConfTip = new decimal[1] ;
         W000E2_n85ConfTip = new bool[] {false} ;
         W000E2_A31FilData = new DateTime[] {DateTime.MinValue} ;
         W000E2_n31FilData = new bool[] {false} ;
         W000E2_A29FilNome = new String[] {""} ;
         W000E2_n29FilNome = new bool[] {false} ;
         W000E2_A28FilCodi = new int[1] ;
         W000E2_n28FilCodi = new bool[] {false} ;
         W000E2_A36MidSitu = new short[1] ;
         W000E2_n36MidSitu = new bool[] {false} ;
         W000E2_A35MidTipo = new short[1] ;
         W000E2_n35MidTipo = new bool[] {false} ;
         W000E2_A37MidCodi = new int[1] ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         n33CatNome = false ;
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         n31FilData = false ;
         n29FilNome = false ;
         n28FilCodi = false ;
         n36MidSitu = false ;
         n35MidTipo = false ;
         A37MidCodi = 0 ;
         gxIsRefreshing = false ;
         AV11Exclui = "" ;
         AV10Editar = "" ;
         AV15Visual = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxindex = 0 ;
         W000E3_A32CatCodi = new int[1] ;
         W000E3_n32CatCodi = new bool[] {false} ;
         W000E3_A33CatNome = new String[] {""} ;
         W000E3_n33CatNome = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpemidia__default(),
            new Object[][] {
                new Object[] {
               W000E2_A32CatCodi, W000E2_n32CatCodi, W000E2_A33CatNome, W000E2_n33CatNome, W000E2_A85ConfTip, W000E2_n85ConfTip, W000E2_A31FilData, W000E2_n31FilData, W000E2_A29FilNome, W000E2_n29FilNome,
               W000E2_A28FilCodi, W000E2_n28FilCodi, W000E2_A36MidSitu, W000E2_n36MidSitu, W000E2_A35MidTipo, W000E2_n35MidTipo, W000E2_A37MidCodi
               }
               , new Object[] {
               W000E3_A32CatCodi, W000E3_A33CatNome, W000E3_n33CatNome
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV9MidTipo ;
      protected short AV8MidSitu ;
      protected short A35MidTipo ;
      protected short A36MidSitu ;
      protected int AV5FilCodi ;
      protected int A28FilCodi ;
      protected int A32CatCodi ;
      protected int A37MidCodi ;
      protected int gxdynajaxindex ;
      protected decimal A85ConfTip ;
      protected String scmdbuf ;
      protected DateTime AV12FilDat ;
      protected DateTime A31FilData ;
      protected bool n32CatCodi ;
      protected bool n33CatNome ;
      protected bool n85ConfTip ;
      protected bool n31FilData ;
      protected bool n29FilNome ;
      protected bool n28FilCodi ;
      protected bool n36MidSitu ;
      protected bool n35MidTipo ;
      protected bool gxIsRefreshing ;
      protected String AV6FilNome ;
      protected String AV13CatNom ;
      protected String A29FilNome ;
      protected String A33CatNome ;
      protected String AV11Exclui ;
      protected String AV10Editar ;
      protected String AV15Visual ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      protected GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpemidia02 subwpemidia02 ;
      protected IDataReader W000E2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000E2_A32CatCodi ;
      protected bool[] W000E2_n32CatCodi ;
      protected String[] W000E2_A33CatNome ;
      protected bool[] W000E2_n33CatNome ;
      protected decimal[] W000E2_A85ConfTip ;
      protected bool[] W000E2_n85ConfTip ;
      protected DateTime[] W000E2_A31FilData ;
      protected bool[] W000E2_n31FilData ;
      protected String[] W000E2_A29FilNome ;
      protected bool[] W000E2_n29FilNome ;
      protected int[] W000E2_A28FilCodi ;
      protected bool[] W000E2_n28FilCodi ;
      protected short[] W000E2_A36MidSitu ;
      protected bool[] W000E2_n36MidSitu ;
      protected short[] W000E2_A35MidTipo ;
      protected bool[] W000E2_n35MidTipo ;
      protected int[] W000E2_A37MidCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavFilcodigo ;
      protected GUIObjectString edtavFilnome ;
      protected GUIObjectDatetime edtavFildata ;
      protected GUIObjectString dynavCatnome ;
      protected GUIObjectShort cmbavMidtipo ;
      protected GUIObjectShort cmbavMidsituacao ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt25 ;
      protected ILabel lbllbl26 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl17 ;
      protected IDataReader W000E3 ;
      protected int[] W000E3_A32CatCodi ;
      protected bool[] W000E3_n32CatCodi ;
      protected String[] W000E3_A33CatNome ;
      protected bool[] W000E3_n33CatNome ;
   }

   public class wpemidia__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000E2( int AV5FilCodi ,
                                           String AV6FilNome ,
                                           DateTime AV12FilDat ,
                                           String AV13CatNom ,
                                           short AV9MidTipo ,
                                           short AV8MidSitu ,
                                           int A28FilCodi ,
                                           String A29FilNome ,
                                           DateTime A31FilData ,
                                           String A33CatNome ,
                                           short A35MidTipo ,
                                           short A36MidSitu )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T2.[CatCodigo], T3.[CatNome], T4.[ConfTipValor], T2.[FilData], T2.[FilNome], T1.[FilCodigo], T1.[MidSituacao], T1.[MidTipo], T1.[MidCodigo] FROM ((([MIDIA] T1 WITH (NOLOCK) LEFT JOIN [FILME] T2 WITH (NOLOCK) ON T2.[FilCodigo] = T1.[FilCodigo]) LEFT JOIN [CATEGORIA] T3 WITH (NOLOCK) ON T3.[CatCodigo] = T2.[CatCodigo]) LEFT JOIN [CONFTIPMIDIA] T4 WITH (NOLOCK) ON T4.[MidTipo] = T1.[MidTipo] AND T4.[CatCodigo] = T2.[CatCodigo])" ;
         sWhereString = "" ;
         if ( ! ((0==AV5FilCodi)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[FilCodigo] = " + StringUtil.Str( (decimal)(AV5FilCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[FilCodigo] = " + StringUtil.Str( (decimal)(AV5FilCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6FilNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6FilNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6FilNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( AV12FilDat != DateTimeUtil.CToD( "0", 2) ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[FilData] = " + ((AV12FilDat>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV12FilDat, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[FilData] = " + ((AV12FilDat>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV12FilDat, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV13CatNom).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T3.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV13CatNom, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T3.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV13CatNom, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( AV9MidTipo != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV9MidTipo), 1, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV9MidTipo), 1, 0) + ")" ;
            }
         }
         if ( ( AV8MidSitu != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[MidSituacao] = " + StringUtil.Str( (decimal)(AV8MidSitu), 1, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[MidSituacao] = " + StringUtil.Str( (decimal)(AV8MidSitu), 1, 0) + ")" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[MidCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000E2( (int)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (int)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (String)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] );
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
          Object[] prmW000E3 ;
          prmW000E3 = new Object[] {
          } ;
          Object[] prmW000E2 ;
          prmW000E2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000E2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000E2,27,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000E3", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (NOLOCK) ORDER BY [CatNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000E3,0,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((short[]) buf[14])[0] = rslt.getShort(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((int[]) buf[16])[0] = rslt.getInt(9) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
