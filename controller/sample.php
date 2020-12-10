<?php
    namespace Application\Block\ExternalForm\Form\Controller;
    use Concrete\Core\Controller\AbstractController; 

    class Sample extends AbstractController{
                
        public function view(){             
            //view()は、外部フォームが開いたときの設定を記述します。            
                $this->set('section', 'start');
                $this->set('isvalid', true);            
                $this->set('title', '商品一覧');                
        }

         private function validate(){
        //最初はバリデーション結果を成功に設定
            $isvalid = true;
            //ここから下に、データ入力状態の検証コードを記述
            //エラーを定義するときは $isvalid = false; とします。          

            //Viewに値を渡す
            $this->set('isvalid', $isvalid);           
            return $isvalid;
        }                                  
                 
    }
    
?>