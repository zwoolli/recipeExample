CREATE FUNCTION getrecipe_name1_text(text) RETURNS recipe as $$
    SELECT *
    FROM recipe
    WHERE recipe.name_1 = $1;
$$ LANGUAGE SQL;

CREATE FUNCTION getrecipe_name2_text(text) RETURNS recipe as $$
    SELECT *
    FROM recipe
    WHERE recipe.name_2 = $1;
$$ LANGUAGE SQL;

CREATE FUNCTION getrecipe_name2_citext(citext) RETURNS recipe as $$
    SELECT *
    FROM recipe
    WHERE recipe.name_2 = $1;
$$ LANGUAGE SQL;

DROP FUNCTION getrecipe_name1_text;
DROP FUNCTION getrecipe_name2_text;
DROP FUNCTION getrecipe_name2_citext;