<?php    
    defined('C5_EXECUTE') or die('Access_Denied.');
    $form = Core::make('helper/form');
    if (isset($response)){
?>
    <div class="container">
        <div class=row>
            <div class="col-sm-12 bg-success">
                <span class="text-primary"><h3>データ更新終了</h3></span>
            </div>
        </div>          
    </div>
    <div class="container">
        <div class="row">
            <button type="button" class="btn btn-success" onclick="location.href='https://demo.survey-support.jp/test/index.php/goods'">戻る</button>
        </div>
    </div>
<?php
    }
    if ($section == 'edit'){
?>
    <form method="post" id="form-edit" action="<?=$view->action('confirm')?>#form">
     <div class="container">
            <div class="row">            
                 <div class="col-sm-6 bg-primary"><span class="text-white"><h2><?=$title;?></h2></span></div>
                 </div>             
        </div>
        <div class="container">
            <div class="row">
<?php
        if (isset($sid) && $sid != ''){
?>
            <div class="col-sm-1" style="padding:5px;">ID</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sid', $sid)?></div> 
<?php            
        } else {
?>
            <div class="col-sm-1" style="padding:5px;">ID</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sid')?></div>
<?php
        }
?>
                        
            </div>
            <div class="row">
<?php            
        if (isset($sname) && $sname != ''){
?>
            <div class="col-sm-1" style="padding:5px;">商品名</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sname', $sname)?></div>
<?php
        }  else {
?>
            <div class="col-sm-1" style="padding:5px;">商品名</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sname')?></div>
<?php
        }
?>          
            </div>
            <div class="row">
<?php
        if (isset($sprice) && $sprice != 0){
?>
            <div class="col-sm-1" style="padding:5px;">価格</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sprice', $sprice)?></div>

<?php
        } else {
?>
            <div class="col-sm-1" style="padding:5px;">価格</div>
            <div class="col-sm-5" style="padding:5px;"><?=$form->text('sprice')?></div>
<?php
        }
        Core::make('helper/validation/token')->output('confirm_form'); 
?>            
            </div>
            <div class="btn-toolbar">
            <div class="row">
                <div class="form-actions"><?=$form->submit('confirm', '更新する', array('style' => ''), 'btn btn-primary')?></div>
                <div class="form-actions">
                    <button type="button" class="btn btn-danger" onclick="location.href='https://demo.survey-support.jp/test/index.php/goods'">戻る</button>
                </div>
            </div>
            </div> 
        </form> 
<?php
    }
?>

      

  