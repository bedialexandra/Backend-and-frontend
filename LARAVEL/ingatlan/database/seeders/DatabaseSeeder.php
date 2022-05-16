<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\File;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     *
     * @return void
     */
    public function run()
    {
       DB::statement('SET FOREIGN_KEY_CHECKS=0');
        \App\Models\Kategoriak::truncate();
        \App\Models\Ingatlanok::truncate();
        DB::statement('SET FOREIGN_KEY_CHECKS=1');
        $kategoriak = [
            (object)['nev'=>'Ház'],
            (object)['nev'=>'Lakás'],
            (object)['nev'=>'Építési telek'],
            (object)['nev'=>'Garázs'],
            (object)['nev'=>'Mezőgazdasági terület'],
            (object)['nev'=>'Ipari ingatlan'],
        ];

        foreach ($kategoriak as $key => $value) {
            \App\Http\Kategoriak::create([
                key($value)=>$value->nev
            ]);
        }

        $json =File::get('database/data/ingatlanok.json');
        $ingatlanok=json_decode($json);

        foreach ($ingatlanok as $key => $value) {
            \App\Http\Ingatlanok::create([
                "id"=>$value->_id,
                "kategoria"=>$value->kategoria,
                "szoveg"=>$value->leiras,
                "hirdetesDatuma"=>$value->hirdetesdatuma,
                "tehermentes"=>$value->tehermentes,
                "ar"=>$value->ar,
                "kepUrl"=>$value->kepUrl,

            ]);
        }
    }
}
